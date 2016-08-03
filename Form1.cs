using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OSIsoft.AF;
using OSIsoft.AF.Asset;


namespace PI_AF_SDK_Async_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           timer1.Start();
        }

        private void UpdateDatabasePicker(object sender, OSIsoft.AF.UI.SelectionChangeEventArgs e)
        {
            afDatabasePicker1.PISystem = piSystemPicker1.PISystem;

           
        }

        private async void btnReadAsync_Click(object sender, EventArgs e)
        {
            // get the list of attributes 
            lstResults.Items.Add(string.Format("{0} - Searching and loading elements", DateTime.Now));

            var db = afDatabasePicker1.AFDatabase;
            var elements = AFElement.FindElementsByTemplate(db, null, db.ElementTemplates[cmbTemplates.Text], true, AFSortField.ID, AFSortOrder.Ascending, 100000);
            AFElement.LoadElementsToDepth(elements, true, 1, 1000000);
            lstResults.Items.Add(string.Format("{0} - Elements loaded", DateTime.Now));

            try
            {
                lstResults.Items.Add(string.Format("{0} - Starting Gathering the data", DateTime.Now));
                List<Task<IList<AFValue>>> dataForAttributes = new List<Task<IList<AFValue>>>();
                foreach (var element in elements)
                {
                    lstResults.Items.Add(string.Format("{0:O} - adding attributes {1}", DateTime.Now, element.GetPath()));
                    var attributesList = new AFAttributeList(element.Attributes);
                    lstResults.Items.Add(string.Format("{0:O} - Starting Gathering the data async for {1}", DateTime.Now, element.GetPath()));
                    dataForAttributes.Add(attributesList.Data.EndOfStreamAsync());
                    lstResults.Items.Add(string.Format("{0:O} - Async call completed {1}", DateTime.Now, element.GetPath()));
                    // IList<AFValue> data = await attributesList.Data.EndOfStreamAsync();


                }
                lstResults.Items.Add(string.Format("{0} - Waiting for data retrieval to complete", DateTime.Now));

                var result= await Task.WhenAll(dataForAttributes);
                List<AFValue> fulllist = new List<AFValue>();
                foreach (var dataset in result)
                {
                        fulllist.AddRange(dataset);
                }

                lstResults.Items.Add(string.Format("{0} - Got {1} values", DateTime.Now, fulllist.Count));
            }
            catch (Exception ex)
            {
                lstResults.Items.Add(ex);
            }
        }


        private void ResetProgressBar()
        {
            progressBar.Value = progressBar.Minimum;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Value++;
            if (progressBar.Value >= progressBar.Maximum)
            {
                ResetProgressBar();
            }

        }

        private void AFDatabaseChanged(object sender, OSIsoft.AF.UI.SelectionChangeEventArgs e)
        {
            //updating the template names
            cmbTemplates.Items.Clear();
            foreach (var afElementTemplate in afDatabasePicker1.AFDatabase.ElementTemplates)
            {
                cmbTemplates.Items.Add(afElementTemplate.Name);
            }
        }

        private void btnReadSync_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

