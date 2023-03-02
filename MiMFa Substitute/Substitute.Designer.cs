namespace MiMFa.Gadget
{
    partial class Substitute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Substitute));
            this.rtb_Left = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.rtb_Right = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_Languages = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_Translate = new System.Windows.Forms.Button();
            this.label_Right = new System.Windows.Forms.Label();
            this.label_Left = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_Left
            // 
            this.rtb_Left.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Left.Location = new System.Drawing.Point(0, 30);
            this.rtb_Left.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_Left.Name = "rtb_Left";
            this.rtb_Left.Size = new System.Drawing.Size(294, 306);
            this.rtb_Left.TabIndex = 0;
            this.rtb_Left.Text = "";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(441, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(289, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // rtb_Right
            // 
            this.rtb_Right.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Right.Location = new System.Drawing.Point(438, 30);
            this.rtb_Right.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_Right.Name = "rtb_Right";
            this.rtb_Right.ReadOnly = true;
            this.rtb_Right.Size = new System.Drawing.Size(295, 306);
            this.rtb_Right.TabIndex = 3;
            this.rtb_Right.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cb_Languages, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rtb_Right, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.rtb_Left, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_Right, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Left, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(733, 365);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // cb_Languages
            // 
            this.cb_Languages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Languages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Languages.DropDownWidth = 300;
            this.cb_Languages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Languages.FormattingEnabled = true;
            this.cb_Languages.Location = new System.Drawing.Point(297, 3);
            this.cb_Languages.Name = "cb_Languages";
            this.cb_Languages.Size = new System.Drawing.Size(138, 23);
            this.cb_Languages.TabIndex = 1;
            this.cb_Languages.SelectedIndexChanged += new System.EventHandler(this.cb_Languages_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Translate, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(297, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(138, 300);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Change);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 123);
            this.panel1.TabIndex = 6;
            // 
            // btn_Change
            // 
            this.btn_Change.AutoSize = true;
            this.btn_Change.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Change.FlatAppearance.BorderSize = 0;
            this.btn_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Change.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Change.Location = new System.Drawing.Point(0, 0);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(138, 41);
            this.btn_Change.TabIndex = 0;
            this.btn_Change.Text = "🔄";
            this.btn_Change.UseVisualStyleBackColor = false;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // btn_Translate
            // 
            this.btn_Translate.AutoSize = true;
            this.btn_Translate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Translate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Translate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Translate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Translate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Translate.Location = new System.Drawing.Point(3, 126);
            this.btn_Translate.Name = "btn_Translate";
            this.btn_Translate.Padding = new System.Windows.Forms.Padding(5);
            this.btn_Translate.Size = new System.Drawing.Size(132, 47);
            this.btn_Translate.TabIndex = 5;
            this.btn_Translate.Text = "TRANSLATE";
            this.btn_Translate.UseVisualStyleBackColor = false;
            this.btn_Translate.Click += new System.EventHandler(this.btn_Translate_Click);
            // 
            // label_Right
            // 
            this.label_Right.AutoSize = true;
            this.label_Right.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Right.Location = new System.Drawing.Point(438, 0);
            this.label_Right.Margin = new System.Windows.Forms.Padding(0);
            this.label_Right.Name = "label_Right";
            this.label_Right.Padding = new System.Windows.Forms.Padding(5);
            this.label_Right.Size = new System.Drawing.Size(295, 30);
            this.label_Right.TabIndex = 7;
            this.label_Right.Text = "Destination";
            this.label_Right.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Left
            // 
            this.label_Left.AutoSize = true;
            this.label_Left.BackColor = System.Drawing.SystemColors.Window;
            this.label_Left.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Left.Location = new System.Drawing.Point(0, 0);
            this.label_Left.Margin = new System.Windows.Forms.Padding(0);
            this.label_Left.Name = "label_Left";
            this.label_Left.Padding = new System.Windows.Forms.Padding(5);
            this.label_Left.Size = new System.Drawing.Size(294, 30);
            this.label_Left.TabIndex = 8;
            this.label_Left.Text = "Source";
            this.label_Left.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Substitute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 365);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Substitute";
            this.Text = "MiMFa Substitute";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Left;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox rtb_Right;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_Translate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.ComboBox cb_Languages;
        private System.Windows.Forms.Label label_Right;
        private System.Windows.Forms.Label label_Left;
    }
}

