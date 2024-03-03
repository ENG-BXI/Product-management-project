namespace manger
{
    partial class Form_show_mng
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
            this._dataGridView1 = new System.Windows.Forms.DataGridView();
            this._textbox_search_name_mng_form2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._textbox_search_id_mng_form2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._textbox_search_price_mng_form2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // _dataGridView1
            // 
            this._dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView1.Location = new System.Drawing.Point(12, 112);
            this._dataGridView1.Name = "_dataGridView1";
            this._dataGridView1.Size = new System.Drawing.Size(776, 326);
            this._dataGridView1.TabIndex = 0;
            this._dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dataGridView1_CellClick);
            this._dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dataGridView1_CellDoubleClick);
            this._dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.go_enter);
            // 
            // _textbox_search_name_mng_form2
            // 
            this._textbox_search_name_mng_form2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textbox_search_name_mng_form2.Location = new System.Drawing.Point(573, 59);
            this._textbox_search_name_mng_form2.Name = "_textbox_search_name_mng_form2";
            this._textbox_search_name_mng_form2.Size = new System.Drawing.Size(215, 33);
            this._textbox_search_name_mng_form2.TabIndex = 1;
            this._textbox_search_name_mng_form2.TextChanged += new System.EventHandler(this.textbox_search_mng_form2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(686, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم المنتج";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(474, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "رقم المنتج";
            // 
            // _textbox_search_id_mng_form2
            // 
            this._textbox_search_id_mng_form2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textbox_search_id_mng_form2.Location = new System.Drawing.Point(350, 59);
            this._textbox_search_id_mng_form2.Name = "_textbox_search_id_mng_form2";
            this._textbox_search_id_mng_form2.Size = new System.Drawing.Size(217, 33);
            this._textbox_search_id_mng_form2.TabIndex = 3;
            this._textbox_search_id_mng_form2.TextChanged += new System.EventHandler(this.textbox_search_id_mng_form2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "سعر المنتج";
            // 
            // _textbox_search_price_mng_form2
            // 
            this._textbox_search_price_mng_form2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textbox_search_price_mng_form2.Location = new System.Drawing.Point(152, 59);
            this._textbox_search_price_mng_form2.Name = "_textbox_search_price_mng_form2";
            this._textbox_search_price_mng_form2.Size = new System.Drawing.Size(192, 33);
            this._textbox_search_price_mng_form2.TabIndex = 5;
            this._textbox_search_price_mng_form2.TextChanged += new System.EventHandler(this.textbox_search_price_mng_form2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "مسح";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_show_mng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._textbox_search_price_mng_form2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._textbox_search_id_mng_form2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._textbox_search_name_mng_form2);
            this.Controls.Add(this._dataGridView1);
            this.Name = "Form_show_mng";
            this.Text = "Form_show_mng";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.go_enter);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _dataGridView1;
        private System.Windows.Forms.TextBox _textbox_search_name_mng_form2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _textbox_search_id_mng_form2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _textbox_search_price_mng_form2;
        private System.Windows.Forms.Button button1;
    }
}