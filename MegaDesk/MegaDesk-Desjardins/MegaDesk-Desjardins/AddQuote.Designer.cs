namespace MegaDesk_Desjardins
{
    partial class AddQuote
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
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.DeskDepth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deskWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.drawers = new System.Windows.Forms.ComboBox();
            this.materialBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shipping = new System.Windows.Forms.ComboBox();
            this.getQuote = new System.Windows.Forms.Button();
            this.depthError = new System.Windows.Forms.Label();
            this.widthError = new System.Windows.Forms.Label();
            this.nameError = new System.Windows.Forms.Label();
            this.drawerError = new System.Windows.Forms.Label();
            this.materialError = new System.Windows.Forms.Label();
            this.shippingError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(12, 330);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(75, 23);
            this.MainMenuButton.TabIndex = 1;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Name";
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(13, 26);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(100, 20);
            this.CustomerName.TabIndex = 3;
            this.CustomerName.TextChanged += new System.EventHandler(this.CustomerName_TextChanged);
            // 
            // DeskDepth
            // 
            this.DeskDepth.Location = new System.Drawing.Point(13, 66);
            this.DeskDepth.Name = "DeskDepth";
            this.DeskDepth.Size = new System.Drawing.Size(100, 20);
            this.DeskDepth.TabIndex = 5;
            this.DeskDepth.TextChanged += new System.EventHandler(this.DeskDepth_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Depth";
            // 
            // deskWidth
            // 
            this.deskWidth.Location = new System.Drawing.Point(13, 106);
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.Size = new System.Drawing.Size(100, 20);
            this.deskWidth.TabIndex = 7;
            this.deskWidth.TextChanged += new System.EventHandler(this.deskWidth_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Drawers";
            // 
            // drawers
            // 
            this.drawers.FormattingEnabled = true;
            this.drawers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.drawers.Location = new System.Drawing.Point(12, 145);
            this.drawers.Name = "drawers";
            this.drawers.Size = new System.Drawing.Size(121, 21);
            this.drawers.TabIndex = 9;
            this.drawers.SelectedIndexChanged += new System.EventHandler(this.drawers_SelectedIndexChanged);
            // 
            // materialBox
            // 
            this.materialBox.FormattingEnabled = true;
            this.materialBox.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.materialBox.Location = new System.Drawing.Point(12, 185);
            this.materialBox.Name = "materialBox";
            this.materialBox.Size = new System.Drawing.Size(121, 21);
            this.materialBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Material";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Shipping";
            // 
            // shipping
            // 
            this.shipping.FormattingEnabled = true;
            this.shipping.Items.AddRange(new object[] {
            "Standard - 14 Days",
            "7 Days",
            "5 Days",
            "3 Days"});
            this.shipping.Location = new System.Drawing.Point(12, 229);
            this.shipping.Name = "shipping";
            this.shipping.Size = new System.Drawing.Size(121, 21);
            this.shipping.TabIndex = 13;
            // 
            // getQuote
            // 
            this.getQuote.AutoSize = true;
            this.getQuote.Location = new System.Drawing.Point(408, 330);
            this.getQuote.Name = "getQuote";
            this.getQuote.Size = new System.Drawing.Size(96, 23);
            this.getQuote.TabIndex = 14;
            this.getQuote.Text = "Submit Quote";
            this.getQuote.UseVisualStyleBackColor = true;
            this.getQuote.Click += new System.EventHandler(this.getQuote_Click);
            // 
            // depthError
            // 
            this.depthError.AutoSize = true;
            this.depthError.Location = new System.Drawing.Point(119, 69);
            this.depthError.Name = "depthError";
            this.depthError.Size = new System.Drawing.Size(140, 13);
            this.depthError.TabIndex = 15;
            this.depthError.Text = "Depth must be 12-48 inches";
            this.depthError.Visible = false;
            // 
            // widthError
            // 
            this.widthError.AutoSize = true;
            this.widthError.Location = new System.Drawing.Point(119, 109);
            this.widthError.Name = "widthError";
            this.widthError.Size = new System.Drawing.Size(139, 13);
            this.widthError.TabIndex = 16;
            this.widthError.Text = "Width must be 24-96 inches";
            this.widthError.Visible = false;
            // 
            // nameError
            // 
            this.nameError.AutoSize = true;
            this.nameError.Location = new System.Drawing.Point(119, 29);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(122, 13);
            this.nameError.TabIndex = 17;
            this.nameError.Text = "Name must not be blank";
            this.nameError.Visible = false;
            // 
            // drawerError
            // 
            this.drawerError.AutoSize = true;
            this.drawerError.Location = new System.Drawing.Point(139, 148);
            this.drawerError.Name = "drawerError";
            this.drawerError.Size = new System.Drawing.Size(169, 13);
            this.drawerError.TabIndex = 18;
            this.drawerError.Text = "Please select a number of drawers";
            this.drawerError.Visible = false;
            // 
            // materialError
            // 
            this.materialError.AutoSize = true;
            this.materialError.Location = new System.Drawing.Point(139, 188);
            this.materialError.Name = "materialError";
            this.materialError.Size = new System.Drawing.Size(118, 13);
            this.materialError.TabIndex = 19;
            this.materialError.Text = "Please select a material";
            this.materialError.Visible = false;
            // 
            // shippingError
            // 
            this.shippingError.AutoSize = true;
            this.shippingError.Location = new System.Drawing.Point(139, 232);
            this.shippingError.Name = "shippingError";
            this.shippingError.Size = new System.Drawing.Size(153, 13);
            this.shippingError.TabIndex = 20;
            this.shippingError.Text = "Please select a shipping option";
            this.shippingError.Visible = false;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 365);
            this.Controls.Add(this.shippingError);
            this.Controls.Add(this.materialError);
            this.Controls.Add(this.drawerError);
            this.Controls.Add(this.nameError);
            this.Controls.Add(this.widthError);
            this.Controls.Add(this.depthError);
            this.Controls.Add(this.getQuote);
            this.Controls.Add(this.shipping);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.drawers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deskWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeskDepth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MainMenuButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.TextBox DeskDepth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox deskWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox drawers;
        private System.Windows.Forms.ComboBox materialBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox shipping;
        private System.Windows.Forms.Button getQuote;
        private System.Windows.Forms.Label depthError;
        private System.Windows.Forms.Label widthError;
        private System.Windows.Forms.Label nameError;
        private System.Windows.Forms.Label drawerError;
        private System.Windows.Forms.Label materialError;
        private System.Windows.Forms.Label shippingError;
    }
}