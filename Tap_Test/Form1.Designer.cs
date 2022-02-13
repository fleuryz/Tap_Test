
using System.Windows.Forms;

namespace Tap_Test
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addDriverButton = new System.Windows.Forms.Button();
            this.loadCsvButton = new System.Windows.Forms.Button();
            this.typesList = new System.Windows.Forms.CheckedListBox();
            this.openCSVDialog = new System.Windows.Forms.OpenFileDialog();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.distanceBox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.addPushButton = new System.Windows.Forms.Button();
            this.fareList = new System.Windows.Forms.CheckedListBox();
            this.calculateFareButton = new System.Windows.Forms.Button();
            this.farePriceLabel = new System.Windows.Forms.Label();
            this.fareResult = new System.Windows.Forms.Label();
            this.fareInfo = new System.Windows.Forms.Label();
            this.fareInfoLabel = new System.Windows.Forms.Label();
            this.driverChosen = new System.Windows.Forms.Label();
            this.driverLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.driversList = new System.Windows.Forms.CheckedListBox();
            this.exportCSVButton = new System.Windows.Forms.Button();
            this.saveCSVDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // addDriverButton
            // 
            this.addDriverButton.Location = new System.Drawing.Point(12, 12);
            this.addDriverButton.Name = "addDriverButton";
            this.addDriverButton.Size = new System.Drawing.Size(216, 101);
            this.addDriverButton.TabIndex = 0;
            this.addDriverButton.Text = "Add Driver";
            this.addDriverButton.UseVisualStyleBackColor = true;
            this.addDriverButton.Click += new System.EventHandler(this.addDriver_Click);
            // 
            // loadCsvButton
            // 
            this.loadCsvButton.Location = new System.Drawing.Point(259, 12);
            this.loadCsvButton.Name = "loadCsvButton";
            this.loadCsvButton.Size = new System.Drawing.Size(216, 101);
            this.loadCsvButton.TabIndex = 1;
            this.loadCsvButton.Text = "Load Fares from CSV";
            this.loadCsvButton.UseVisualStyleBackColor = true;
            this.loadCsvButton.Click += new System.EventHandler(this.loadCsv_Click);
            // 
            // typesList
            // 
            this.typesList.CheckOnClick = true;
            this.typesList.Enabled = false;
            this.typesList.FormattingEnabled = true;
            this.typesList.Location = new System.Drawing.Point(117, 131);
            this.typesList.Name = "typesList";
            this.typesList.Size = new System.Drawing.Size(124, 40);
            this.typesList.TabIndex = 3;
            // 
            // openCSVDialog
            // 
            this.openCSVDialog.FileName = "openCSVDialog";
            // 
            // nameBox
            // 
            this.nameBox.Enabled = false;
            this.nameBox.Location = new System.Drawing.Point(117, 197);
            this.nameBox.Name = "nameBox";
            this.nameBox.PlaceholderText = "[name]";
            this.nameBox.Size = new System.Drawing.Size(124, 23);
            this.nameBox.TabIndex = 4;
            // 
            // surnameBox
            // 
            this.surnameBox.Enabled = false;
            this.surnameBox.Location = new System.Drawing.Point(117, 235);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.PlaceholderText = "[surname]";
            this.surnameBox.Size = new System.Drawing.Size(124, 23);
            this.surnameBox.TabIndex = 5;
            // 
            // emailBox
            // 
            this.emailBox.Enabled = false;
            this.emailBox.Location = new System.Drawing.Point(117, 274);
            this.emailBox.Name = "emailBox";
            this.emailBox.PlaceholderText = "[e-mail]";
            this.emailBox.Size = new System.Drawing.Size(124, 23);
            this.emailBox.TabIndex = 6;
            // 
            // priceBox
            // 
            this.priceBox.Enabled = false;
            this.priceBox.Location = new System.Drawing.Point(117, 317);
            this.priceBox.Name = "priceBox";
            this.priceBox.PlaceholderText = "[price]";
            this.priceBox.Size = new System.Drawing.Size(124, 23);
            this.priceBox.TabIndex = 7;
            // 
            // distanceBox
            // 
            this.distanceBox.Enabled = false;
            this.distanceBox.Location = new System.Drawing.Point(117, 357);
            this.distanceBox.Name = "distanceBox";
            this.distanceBox.PlaceholderText = "[distance]";
            this.distanceBox.Size = new System.Drawing.Size(124, 23);
            this.distanceBox.TabIndex = 8;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Enabled = false;
            this.typeLabel.Location = new System.Drawing.Point(9, 141);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(71, 15);
            this.typeLabel.TabIndex = 9;
            this.typeLabel.Text = "Vehicle Type";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Enabled = false;
            this.nameLabel.Location = new System.Drawing.Point(9, 200);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 15);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Name";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Enabled = false;
            this.surnameLabel.Location = new System.Drawing.Point(9, 238);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(54, 15);
            this.surnameLabel.TabIndex = 11;
            this.surnameLabel.Text = "Surname";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Enabled = false;
            this.emailLabel.Location = new System.Drawing.Point(9, 277);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(41, 15);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "E-mail";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Enabled = false;
            this.priceLabel.Location = new System.Drawing.Point(9, 320);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(85, 15);
            this.priceLabel.TabIndex = 13;
            this.priceLabel.Text = "Base Fare Price";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Enabled = false;
            this.distanceLabel.Location = new System.Drawing.Point(9, 357);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(104, 15);
            this.distanceLabel.TabIndex = 14;
            this.distanceLabel.Text = "Base Fare Distance";
            // 
            // addPushButton
            // 
            this.addPushButton.Enabled = false;
            this.addPushButton.Location = new System.Drawing.Point(117, 402);
            this.addPushButton.Name = "addPushButton";
            this.addPushButton.Size = new System.Drawing.Size(75, 23);
            this.addPushButton.TabIndex = 15;
            this.addPushButton.Text = "Add";
            this.addPushButton.UseVisualStyleBackColor = true;
            this.addPushButton.Click += new System.EventHandler(this.addPush_Click);
            // 
            // fareList
            // 
            this.fareList.CheckOnClick = true;
            this.fareList.FormattingEnabled = true;
            this.fareList.Location = new System.Drawing.Point(259, 131);
            this.fareList.Name = "fareList";
            this.fareList.Size = new System.Drawing.Size(216, 130);
            this.fareList.TabIndex = 16;
            // 
            // calculateFareButton
            // 
            this.calculateFareButton.Enabled = false;
            this.calculateFareButton.Location = new System.Drawing.Point(526, 12);
            this.calculateFareButton.Name = "calculateFareButton";
            this.calculateFareButton.Size = new System.Drawing.Size(216, 101);
            this.calculateFareButton.TabIndex = 17;
            this.calculateFareButton.Text = "Calculate Fare";
            this.calculateFareButton.UseVisualStyleBackColor = true;
            this.calculateFareButton.Click += new System.EventHandler(this.calculateFare_Click);
            // 
            // farePriceLabel
            // 
            this.farePriceLabel.AutoSize = true;
            this.farePriceLabel.Location = new System.Drawing.Point(526, 179);
            this.farePriceLabel.Name = "farePriceLabel";
            this.farePriceLabel.Size = new System.Drawing.Size(61, 15);
            this.farePriceLabel.TabIndex = 18;
            this.farePriceLabel.Text = "Final Price";
            // 
            // fareResult
            // 
            this.fareResult.AutoSize = true;
            this.fareResult.Location = new System.Drawing.Point(605, 179);
            this.fareResult.Name = "fareResult";
            this.fareResult.Size = new System.Drawing.Size(24, 15);
            this.fareResult.TabIndex = 19;
            this.fareResult.Text = "[...]";
            // 
            // fareInfo
            // 
            this.fareInfo.AutoSize = true;
            this.fareInfo.Location = new System.Drawing.Point(605, 156);
            this.fareInfo.Name = "fareInfo";
            this.fareInfo.Size = new System.Drawing.Size(24, 15);
            this.fareInfo.TabIndex = 22;
            this.fareInfo.Text = "[...]";
            // 
            // fareInfoLabel
            // 
            this.fareInfoLabel.AutoSize = true;
            this.fareInfoLabel.Location = new System.Drawing.Point(526, 156);
            this.fareInfoLabel.Name = "fareInfoLabel";
            this.fareInfoLabel.Size = new System.Drawing.Size(29, 15);
            this.fareInfoLabel.TabIndex = 21;
            this.fareInfoLabel.Text = "Fare";
            // 
            // driverChosen
            // 
            this.driverChosen.AutoSize = true;
            this.driverChosen.Location = new System.Drawing.Point(605, 206);
            this.driverChosen.Name = "driverChosen";
            this.driverChosen.Size = new System.Drawing.Size(24, 15);
            this.driverChosen.TabIndex = 24;
            this.driverChosen.Text = "[...]";
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.Location = new System.Drawing.Point(526, 206);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(38, 15);
            this.driverLabel.TabIndex = 23;
            this.driverLabel.Text = "Driver";
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(19, 402);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 25;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // driversList
            // 
            this.driversList.CheckOnClick = true;
            this.driversList.FormattingEnabled = true;
            this.driversList.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.driversList.Location = new System.Drawing.Point(259, 293);
            this.driversList.Name = "driversList";
            this.driversList.Size = new System.Drawing.Size(216, 130);
            this.driversList.TabIndex = 26;
            // 
            // exportCSVButton
            // 
            this.exportCSVButton.Enabled = false;
            this.exportCSVButton.Location = new System.Drawing.Point(526, 304);
            this.exportCSVButton.Name = "exportCSVButton";
            this.exportCSVButton.Size = new System.Drawing.Size(216, 101);
            this.exportCSVButton.TabIndex = 27;
            this.exportCSVButton.Text = "Export Fare CSV";
            this.exportCSVButton.UseVisualStyleBackColor = true;
            this.exportCSVButton.Click += new System.EventHandler(this.exportCSV_Click);
            // 
            // saveCSVDialog
            // 
            this.saveCSVDialog.FileName = "cheapestFares.csv";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exportCSVButton);
            this.Controls.Add(this.driversList);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.driverChosen);
            this.Controls.Add(this.driverLabel);
            this.Controls.Add(this.fareInfo);
            this.Controls.Add(this.fareInfoLabel);
            this.Controls.Add(this.fareResult);
            this.Controls.Add(this.farePriceLabel);
            this.Controls.Add(this.calculateFareButton);
            this.Controls.Add(this.fareList);
            this.Controls.Add(this.addPushButton);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.distanceBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.typesList);
            this.Controls.Add(this.loadCsvButton);
            this.Controls.Add(this.addDriverButton);
            this.Name = "MainPage";
            this.Text = "Fare Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addDriverButton;
        private System.Windows.Forms.Button loadCsvButton;
        private System.Windows.Forms.CheckedListBox typesList;
        private System.Windows.Forms.OpenFileDialog openCSVDialog;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox distanceBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Button addPushButton;
        private System.Windows.Forms.CheckedListBox fareList;
        private System.Windows.Forms.Button calculateFareButton;
        private System.Windows.Forms.Label farePriceLabel;
        private System.Windows.Forms.Label fareResult;
        private System.Windows.Forms.Label fareInfo;
        private System.Windows.Forms.Label fareInfoLabel;
        private System.Windows.Forms.Label driverChosen;
        private System.Windows.Forms.Label driverLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckedListBox driversList;
        private Button exportCSVButton;
        private SaveFileDialog saveCSVDialog;
    }
}

