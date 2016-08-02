namespace PI_AF_SDK_Async_Demo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnReadSync = new System.Windows.Forms.Button();
            this.btnReadAsync = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.piSystemPicker1 = new OSIsoft.AF.UI.PISystemPicker();
            this.label1 = new System.Windows.Forms.Label();
            this.afDatabasePicker1 = new OSIsoft.AF.UI.AFDatabasePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTemplates = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnReadSync
            // 
            this.btnReadSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReadSync.Location = new System.Drawing.Point(456, 12);
            this.btnReadSync.Name = "btnReadSync";
            this.btnReadSync.Size = new System.Drawing.Size(180, 60);
            this.btnReadSync.TabIndex = 0;
            this.btnReadSync.Text = "Read Values Synchronously";
            this.btnReadSync.UseVisualStyleBackColor = true;
            this.btnReadSync.Click += new System.EventHandler(this.btnReadSync_Click);
            // 
            // btnReadAsync
            // 
            this.btnReadAsync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReadAsync.Location = new System.Drawing.Point(456, 78);
            this.btnReadAsync.Name = "btnReadAsync";
            this.btnReadAsync.Size = new System.Drawing.Size(180, 60);
            this.btnReadAsync.TabIndex = 1;
            this.btnReadAsync.Text = "Read Values asynchronously";
            this.btnReadAsync.UseVisualStyleBackColor = true;
            this.btnReadAsync.Click += new System.EventHandler(this.btnReadAsync_Click);
            // 
            // lstResults
            // 
            this.lstResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(16, 200);
            this.lstResults.Name = "lstResults";
            this.lstResults.ScrollAlwaysVisible = true;
            this.lstResults.Size = new System.Drawing.Size(620, 537);
            this.lstResults.TabIndex = 2;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(16, 171);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(620, 23);
            this.progressBar.Step = 5;
            this.progressBar.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // piSystemPicker1
            // 
            this.piSystemPicker1.AccessibleDescription = "PI System Picker";
            this.piSystemPicker1.AccessibleName = "PI System Picker";
            this.piSystemPicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.piSystemPicker1.EnableBegin = false;
            this.piSystemPicker1.EnableDelete = false;
            this.piSystemPicker1.EnableEnd = false;
            this.piSystemPicker1.EnableList = false;
            this.piSystemPicker1.EnableNavigation = false;
            this.piSystemPicker1.EnableNew = false;
            this.piSystemPicker1.EnableNext = false;
            this.piSystemPicker1.EnablePrevious = false;
            this.piSystemPicker1.Location = new System.Drawing.Point(16, 31);
            this.piSystemPicker1.LoginPromptSetting = OSIsoft.AF.UI.PISystemPicker.LoginPromptSettingOptions.Default;
            this.piSystemPicker1.Name = "piSystemPicker1";
            this.piSystemPicker1.ShowBegin = false;
            this.piSystemPicker1.ShowDelete = false;
            this.piSystemPicker1.ShowEnd = false;
            this.piSystemPicker1.ShowFind = false;
            this.piSystemPicker1.ShowImages = false;
            this.piSystemPicker1.ShowNavigation = false;
            this.piSystemPicker1.ShowNew = false;
            this.piSystemPicker1.ShowNext = false;
            this.piSystemPicker1.ShowPrevious = false;
            this.piSystemPicker1.Size = new System.Drawing.Size(317, 21);
            this.piSystemPicker1.TabIndex = 4;
            this.piSystemPicker1.ConnectionChange += new OSIsoft.AF.UI.ConnectionChangeEventHandler(this.UpdateDatabasePicker);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select AF Server";
            // 
            // afDatabasePicker1
            // 
            this.afDatabasePicker1.AccessibleDescription = "Database Picker";
            this.afDatabasePicker1.AccessibleName = "Database Picker";
            this.afDatabasePicker1.Location = new System.Drawing.Point(16, 78);
            this.afDatabasePicker1.Name = "afDatabasePicker1";
            this.afDatabasePicker1.ShowBegin = false;
            this.afDatabasePicker1.ShowConfigurationDatabase = OSIsoft.AF.UI.ShowConfigurationDatabase.Hide;
            this.afDatabasePicker1.ShowDelete = false;
            this.afDatabasePicker1.ShowEnd = false;
            this.afDatabasePicker1.ShowFind = false;
            this.afDatabasePicker1.ShowImages = false;
            this.afDatabasePicker1.ShowList = false;
            this.afDatabasePicker1.ShowNavigation = false;
            this.afDatabasePicker1.ShowNew = false;
            this.afDatabasePicker1.ShowNext = false;
            this.afDatabasePicker1.ShowNoEntries = false;
            this.afDatabasePicker1.ShowPrevious = false;
            this.afDatabasePicker1.ShowProperties = false;
            this.afDatabasePicker1.Size = new System.Drawing.Size(317, 21);
            this.afDatabasePicker1.TabIndex = 6;
            this.afDatabasePicker1.SelectionChange += new OSIsoft.AF.UI.SelectionChangeEventHandler(this.AFDatabaseChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select AF Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select a template to load elements from";
            // 
            // cmbTemplates
            // 
            this.cmbTemplates.FormattingEnabled = true;
            this.cmbTemplates.Location = new System.Drawing.Point(16, 129);
            this.cmbTemplates.Name = "cmbTemplates";
            this.cmbTemplates.Size = new System.Drawing.Size(317, 21);
            this.cmbTemplates.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 763);
            this.Controls.Add(this.cmbTemplates);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.afDatabasePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.piSystemPicker1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnReadAsync);
            this.Controls.Add(this.btnReadSync);
            this.Name = "Form1";
            this.Text = "PI AF SDK Async Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadSync;
        private System.Windows.Forms.Button btnReadAsync;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer1;
        private OSIsoft.AF.UI.PISystemPicker piSystemPicker1;
        private System.Windows.Forms.Label label1;
        private OSIsoft.AF.UI.AFDatabasePicker afDatabasePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTemplates;
    }
}

