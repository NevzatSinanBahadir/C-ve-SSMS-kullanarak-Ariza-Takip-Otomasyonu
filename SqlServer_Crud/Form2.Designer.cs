namespace SqlServer_Crud
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textAriza = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblkalan = new System.Windows.Forms.Label();
            this.lblgirilengun = new System.Windows.Forms.Label();
            this.txtAcıklama = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.arızalarDataSet = new SqlServer_Crud.ArızalarDataSet();
            this.bilgilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bilgilerTableAdapter = new SqlServer_Crud.ArızalarDataSetTableAdapters.BilgilerTableAdapter();
            this.bilgilerTableAdapter1 = new SqlServer_Crud.ArızalarDataSetTableAdapters.BilgilerTableAdapter();
            this.arızalarDataSet1 = new SqlServer_Crud.ArızalarDataSet();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.arızalarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arızalarDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(626, 49);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(333, 28);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(560, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tarih";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textAriza
            // 
            this.textAriza.BackColor = System.Drawing.Color.White;
            this.textAriza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAriza.ForeColor = System.Drawing.Color.Black;
            this.textAriza.Location = new System.Drawing.Point(364, 49);
            this.textAriza.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textAriza.Name = "textAriza";
            this.textAriza.Size = new System.Drawing.Size(160, 28);
            this.textAriza.TabIndex = 9;
            this.textAriza.TextChanged += new System.EventHandler(this.textAriza_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(287, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ariza";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(74, 49);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(162, 28);
            this.txtID.TabIndex = 7;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(23, 465);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "TIKLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblkalan
            // 
            this.lblkalan.AutoSize = true;
            this.lblkalan.BackColor = System.Drawing.Color.White;
            this.lblkalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkalan.ForeColor = System.Drawing.Color.Black;
            this.lblkalan.Location = new System.Drawing.Point(20, 417);
            this.lblkalan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkalan.Name = "lblkalan";
            this.lblkalan.Size = new System.Drawing.Size(205, 24);
            this.lblkalan.TabIndex = 16;
            this.lblkalan.Text = "Toplan Arıza Süresi :";
            this.lblkalan.Click += new System.EventHandler(this.lblkalan_Click);
            // 
            // lblgirilengun
            // 
            this.lblgirilengun.AutoSize = true;
            this.lblgirilengun.BackColor = System.Drawing.Color.White;
            this.lblgirilengun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgirilengun.ForeColor = System.Drawing.Color.Black;
            this.lblgirilengun.Location = new System.Drawing.Point(20, 361);
            this.lblgirilengun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgirilengun.Name = "lblgirilengun";
            this.lblgirilengun.Size = new System.Drawing.Size(224, 24);
            this.lblgirilengun.TabIndex = 17;
            this.lblgirilengun.Text = "Arıza Başlangıç Tarihi :";
            // 
            // txtAcıklama
            // 
            this.txtAcıklama.BackColor = System.Drawing.Color.White;
            this.txtAcıklama.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAcıklama.ForeColor = System.Drawing.Color.Black;
            this.txtAcıklama.Location = new System.Drawing.Point(332, 365);
            this.txtAcıklama.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAcıklama.Multiline = true;
            this.txtAcıklama.Name = "txtAcıklama";
            this.txtAcıklama.Size = new System.Drawing.Size(394, 102);
            this.txtAcıklama.TabIndex = 18;
            this.txtAcıklama.Tag = "";
            this.txtAcıklama.TextChanged += new System.EventHandler(this.txtAcıklama_TextChanged);
            this.txtAcıklama.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAcıklama_KeyUp);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(616, 475);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 31);
            this.button2.TabIndex = 20;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // arızalarDataSet
            // 
            this.arızalarDataSet.DataSetName = "ArızalarDataSet";
            this.arızalarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bilgilerBindingSource
            // 
            this.bilgilerBindingSource.DataMember = "Bilgiler";
            this.bilgilerBindingSource.DataSource = this.arızalarDataSet;
            // 
            // bilgilerTableAdapter
            // 
            this.bilgilerTableAdapter.ClearBeforeFill = true;
            // 
            // bilgilerTableAdapter1
            // 
            this.bilgilerTableAdapter1.ClearBeforeFill = true;
            // 
            // arızalarDataSet1
            // 
            this.arızalarDataSet1.DataSetName = "ArızalarDataSet";
            this.arızalarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(332, 478);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 26);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(497, 475);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 31);
            this.button3.TabIndex = 22;
            this.button3.Text = "Getir";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(965, 521);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtAcıklama);
            this.Controls.Add(this.lblgirilengun);
            this.Controls.Add(this.lblkalan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textAriza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Arıza Bilgi Ekranı";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arızalarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arızalarDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ArızalarDataSet arızalarDataSet;
        private System.Windows.Forms.BindingSource bilgilerBindingSource;
        private ArızalarDataSetTableAdapters.BilgilerTableAdapter bilgilerTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox textAriza;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblkalan;
        private System.Windows.Forms.Label lblgirilengun;
        private ArızalarDataSetTableAdapters.BilgilerTableAdapter bilgilerTableAdapter1;
        private System.Windows.Forms.Button button2;
        private ArızalarDataSet arızalarDataSet1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.TextBox txtAcıklama;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}