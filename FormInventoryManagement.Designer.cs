namespace EquipmentListTable
{
    partial class FormInventoryManagement
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridViewEquipmentList = new DataGridView();
            labelTitle = new Label();
            buttonNewEquipment = new Button();
            buttonUpdateSelected = new Button();
            textBoxFilter = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            languageToolStripMenuItem = new ToolStripMenuItem();
            türkçeToolStripMenuItem = new ToolStripMenuItem();
            englishToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            userGuideToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEquipmentList).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewEquipmentList
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewEquipmentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewEquipmentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewEquipmentList.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewEquipmentList.Location = new Point(37, 157);
            dataGridViewEquipmentList.Name = "dataGridViewEquipmentList";
            dataGridViewEquipmentList.RowHeadersWidth = 51;
            dataGridViewEquipmentList.RowTemplate.Height = 29;
            dataGridViewEquipmentList.Size = new Size(2019, 608);
            dataGridViewEquipmentList.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(37, 53);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(405, 31);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "EQUIPMENT REGISTRATION SYSTEM";
            // 
            // buttonNewEquipment
            // 
            buttonNewEquipment.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNewEquipment.Location = new Point(127, 804);
            buttonNewEquipment.Name = "buttonNewEquipment";
            buttonNewEquipment.Size = new Size(218, 56);
            buttonNewEquipment.TabIndex = 2;
            buttonNewEquipment.Text = "New Equipment";
            buttonNewEquipment.UseVisualStyleBackColor = true;
            buttonNewEquipment.Click += buttonNewEquipment_Click;
            // 
            // buttonUpdateSelected
            // 
            buttonUpdateSelected.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdateSelected.Location = new Point(425, 804);
            buttonUpdateSelected.Name = "buttonUpdateSelected";
            buttonUpdateSelected.Size = new Size(218, 56);
            buttonUpdateSelected.TabIndex = 3;
            buttonUpdateSelected.Text = "Update Selected Data";
            buttonUpdateSelected.UseVisualStyleBackColor = true;
            buttonUpdateSelected.Click += buttonUpdateSelected_Click;
            // 
            // textBoxFilter
            // 
            textBoxFilter.ForeColor = SystemColors.ScrollBar;
            textBoxFilter.Location = new Point(37, 101);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(578, 28);
            textBoxFilter.TabIndex = 1;
            textBoxFilter.Text = "Please type for searching...";
            textBoxFilter.MouseClick += textBoxFilter_MouseClick;
            textBoxFilter.TextChanged += textBoxFilter_TextChanged;
            textBoxFilter.Leave += textBoxFilter_Leave;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, languageToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2098, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(169, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // languageToolStripMenuItem
            // 
            languageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { türkçeToolStripMenuItem, englishToolStripMenuItem });
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            languageToolStripMenuItem.Size = new Size(88, 24);
            languageToolStripMenuItem.Text = "Language";
            // 
            // türkçeToolStripMenuItem
            // 
            türkçeToolStripMenuItem.Name = "türkçeToolStripMenuItem";
            türkçeToolStripMenuItem.Size = new Size(139, 26);
            türkçeToolStripMenuItem.Text = "Türkçe";
            türkçeToolStripMenuItem.Click += türkçeToolStripMenuItem_Click;
            // 
            // englishToolStripMenuItem
            // 
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            englishToolStripMenuItem.Size = new Size(139, 26);
            englishToolStripMenuItem.Text = "English";
            englishToolStripMenuItem.Click += englishToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userGuideToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // userGuideToolStripMenuItem
            // 
            userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            userGuideToolStripMenuItem.ShortcutKeys = Keys.F1;
            userGuideToolStripMenuItem.Size = new Size(188, 26);
            userGuideToolStripMenuItem.Text = "User Guide";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(188, 26);
            aboutToolStripMenuItem.Text = "About";
            // 
            // FormInventoryManagement
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(2098, 921);
            Controls.Add(textBoxFilter);
            Controls.Add(buttonUpdateSelected);
            Controls.Add(buttonNewEquipment);
            Controls.Add(labelTitle);
            Controls.Add(dataGridViewEquipmentList);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Name = "FormInventoryManagement";
            Text = "Inventory Management";
            Load += FormEquipmentList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEquipmentList).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTitle;
        private Button buttonNewEquipment;
        private Button buttonUpdateSelected;
        private TextBox textBoxFilter;
        public DataGridView dataGridViewEquipmentList;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem userGuideToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem türkçeToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
    }
}