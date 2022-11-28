namespace VehicleRegistrationPlateWinForms
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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelRego = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonBinarySearch = new System.Windows.Forms.Button();
            this.buttonLinearSearch = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonTag = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTipOpen = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSave = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAdd = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEdit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipExitDelete = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipTag = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBinarySearch = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLinearSearch = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipResetClear = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipListBox = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipTextBox = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(13, 13);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open";
            this.toolTipOpen.SetToolTip(this.buttonOpen, "Opens a file containing a list of registration plates");
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(95, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.toolTipSave.SetToolTip(this.buttonSave, "Saves the list of registration plates to a file");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelRego
            // 
            this.labelRego.AutoSize = true;
            this.labelRego.Location = new System.Drawing.Point(13, 43);
            this.labelRego.Name = "labelRego";
            this.labelRego.Size = new System.Drawing.Size(36, 13);
            this.labelRego.TabIndex = 2;
            this.labelRego.Text = "Rego:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.toolTipTextBox.SetToolTip(this.textBox1, "Displays a selected registration plate or accepts user input for manual entry of " +
        "registration plate");
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(158, 40);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.toolTipAdd.SetToolTip(this.buttonAdd, "Adds a registration plate to the list");
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(158, 69);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Edit";
            this.toolTipEdit.SetToolTip(this.buttonEdit, "Edits a selected registration plate");
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(158, 98);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Exit (Delete)";
            this.toolTipExitDelete.SetToolTip(this.buttonDelete, "Deletes a selected registration plate from the list");
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonBinarySearch
            // 
            this.buttonBinarySearch.Location = new System.Drawing.Point(52, 69);
            this.buttonBinarySearch.Name = "buttonBinarySearch";
            this.buttonBinarySearch.Size = new System.Drawing.Size(90, 23);
            this.buttonBinarySearch.TabIndex = 7;
            this.buttonBinarySearch.Text = "Binary Search";
            this.toolTipBinarySearch.SetToolTip(this.buttonBinarySearch, "Searches for a registration plate with a binary search algorithm");
            this.buttonBinarySearch.UseVisualStyleBackColor = true;
            this.buttonBinarySearch.Click += new System.EventHandler(this.buttonBinarySearch_Click);
            // 
            // buttonLinearSearch
            // 
            this.buttonLinearSearch.Location = new System.Drawing.Point(52, 99);
            this.buttonLinearSearch.Name = "buttonLinearSearch";
            this.buttonLinearSearch.Size = new System.Drawing.Size(90, 23);
            this.buttonLinearSearch.TabIndex = 8;
            this.buttonLinearSearch.Text = "Linear Search";
            this.toolTipLinearSearch.SetToolTip(this.buttonLinearSearch, "Searches a registration plate with a Linear Search algorithm");
            this.buttonLinearSearch.UseVisualStyleBackColor = true;
            this.buttonLinearSearch.Click += new System.EventHandler(this.buttonLinearSearch_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(239, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 420);
            this.listBox1.TabIndex = 9;
            this.toolTipListBox.SetToolTip(this.listBox1, "Displays a list of registration plates");
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(25, 174);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(99, 23);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "Reset (Clear)";
            this.toolTipResetClear.SetToolTip(this.buttonReset, "Resets or clears the list");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonTag
            // 
            this.buttonTag.Location = new System.Drawing.Point(158, 127);
            this.buttonTag.Name = "buttonTag";
            this.buttonTag.Size = new System.Drawing.Size(75, 23);
            this.buttonTag.TabIndex = 11;
            this.buttonTag.Text = "Tag";
            this.toolTipTag.SetToolTip(this.buttonTag, "Tags or untags a selected registration plate");
            this.buttonTag.UseVisualStyleBackColor = true;
            this.buttonTag.Click += new System.EventHandler(this.buttonTag_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 435);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(401, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolTipOpen
            // 
            this.toolTipOpen.ToolTipTitle = "Open";
            this.toolTipOpen.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTipOpen_Popup);
            // 
            // toolTipSave
            // 
            this.toolTipSave.ToolTipTitle = "Save";
            // 
            // toolTipAdd
            // 
            this.toolTipAdd.ToolTipTitle = "Add";
            // 
            // toolTipEdit
            // 
            this.toolTipEdit.ToolTipTitle = "Edit";
            // 
            // toolTipExitDelete
            // 
            this.toolTipExitDelete.ToolTipTitle = "Exit (Delete)";
            // 
            // toolTipTag
            // 
            this.toolTipTag.ToolTipTitle = "Tag";
            // 
            // toolTipBinarySearch
            // 
            this.toolTipBinarySearch.ToolTipTitle = "Binary Search";
            // 
            // toolTipLinearSearch
            // 
            this.toolTipLinearSearch.ToolTipTitle = "Linear Search";
            // 
            // toolTipResetClear
            // 
            this.toolTipResetClear.ToolTipTitle = "Reset (Clear)";
            // 
            // toolTipListBox
            // 
            this.toolTipListBox.ToolTipTitle = "List Box";
            // 
            // toolTipTextBox
            // 
            this.toolTipTextBox.ToolTipTitle = "Text Box";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 457);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonTag);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonLinearSearch);
            this.Controls.Add(this.buttonBinarySearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelRego);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Name = "Form1";
            this.Text = "Vehicle Registration Plate App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelRego;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonBinarySearch;
        private System.Windows.Forms.Button buttonLinearSearch;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonTag;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolTip toolTipOpen;
        private System.Windows.Forms.ToolTip toolTipSave;
        private System.Windows.Forms.ToolTip toolTipAdd;
        private System.Windows.Forms.ToolTip toolTipEdit;
        private System.Windows.Forms.ToolTip toolTipExitDelete;
        private System.Windows.Forms.ToolTip toolTipBinarySearch;
        private System.Windows.Forms.ToolTip toolTipLinearSearch;
        private System.Windows.Forms.ToolTip toolTipResetClear;
        private System.Windows.Forms.ToolTip toolTipTag;
        private System.Windows.Forms.ToolTip toolTipTextBox;
        private System.Windows.Forms.ToolTip toolTipListBox;
    }
}

