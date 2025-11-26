namespace projetDB
{
    partial class PagePrincipale 
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
            button1 = new Button();
            description_TEXTBOX = new TextBox();
            button2 = new Button();
            status_TEXTBOX = new TextBox();
            date_DATETIMEPICKER = new DateTimePicker();
            id_LABEL = new Label();
            description_LABEL = new Label();
            status_LABEL = new Label();
            date_LABEL = new Label();
            dataGrid = new DataGridView();
            Description = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(704, -7);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // description_TEXTBOX
            // 
            description_TEXTBOX.Location = new Point(289, 94);
            description_TEXTBOX.Name = "description_TEXTBOX";
            description_TEXTBOX.Size = new Size(100, 23);
            description_TEXTBOX.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(289, 213);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // status_TEXTBOX
            // 
            status_TEXTBOX.Location = new Point(289, 134);
            status_TEXTBOX.Name = "status_TEXTBOX";
            status_TEXTBOX.Size = new Size(100, 23);
            status_TEXTBOX.TabIndex = 3;
            // 
            // date_DATETIMEPICKER
            // 
            date_DATETIMEPICKER.Location = new Point(289, 173);
            date_DATETIMEPICKER.Name = "date_DATETIMEPICKER";
            date_DATETIMEPICKER.Size = new Size(200, 23);
            date_DATETIMEPICKER.TabIndex = 4;
            // 
            // id_LABEL
            // 
            id_LABEL.AutoSize = true;
            id_LABEL.Location = new Point(289, 65);
            id_LABEL.Name = "id_LABEL";
            id_LABEL.Size = new Size(38, 15);
            id_LABEL.TabIndex = 5;
            id_LABEL.Text = "label1";
            // 
            // description_LABEL
            // 
            description_LABEL.AutoSize = true;
            description_LABEL.Location = new Point(152, 97);
            description_LABEL.Name = "description_LABEL";
            description_LABEL.Size = new Size(131, 15);
            description_LABEL.TabIndex = 6;
            description_LABEL.Text = "Description (MAX 1000)";
            // 
            // status_LABEL
            // 
            status_LABEL.AutoSize = true;
            status_LABEL.Location = new Point(235, 142);
            status_LABEL.Name = "status_LABEL";
            status_LABEL.Size = new Size(48, 15);
            status_LABEL.TabIndex = 7;
            status_LABEL.Text = "Status : ";
            // 
            // date_LABEL
            // 
            date_LABEL.AutoSize = true;
            date_LABEL.Location = new Point(243, 179);
            date_LABEL.Name = "date_LABEL";
            date_LABEL.Size = new Size(40, 15);
            date_LABEL.TabIndex = 8;
            date_LABEL.Text = "Date : ";
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { Description, Status, Date, Id });
            dataGrid.Location = new Point(115, 251);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(608, 150);
            dataGrid.TabIndex = 9;
            dataGrid.CellContentClick += dataGrid_CellContentClick;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // PagePrincipale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGrid);
            Controls.Add(date_LABEL);
            Controls.Add(status_LABEL);
            Controls.Add(description_LABEL);
            Controls.Add(id_LABEL);
            Controls.Add(date_DATETIMEPICKER);
            Controls.Add(status_TEXTBOX);
            Controls.Add(button2);
            Controls.Add(description_TEXTBOX);
            Controls.Add(button1);
            Name = "PagePrincipale";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox description_TEXTBOX;
        private Button button2;
        private TextBox status_TEXTBOX;
        private DateTimePicker date_DATETIMEPICKER;
        private Label id_LABEL;
        private Label description_LABEL;
        private Label status_LABEL;
        private Label date_LABEL;
        private DataGridView dataGrid;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Id;
    }
}
