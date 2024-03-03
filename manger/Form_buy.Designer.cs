namespace manger
{
    partial class Form_buy
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
            this._price_all_form_buy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._paid_up_form_buy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._Residual_form_buy = new System.Windows.Forms.TextBox();
            this._ok_form_buy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _price_all_form_buy
            // 
            this._price_all_form_buy.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._price_all_form_buy.Location = new System.Drawing.Point(27, 77);
            this._price_all_form_buy.Name = "_price_all_form_buy";
            this._price_all_form_buy.ReadOnly = true;
            this._price_all_form_buy.Size = new System.Drawing.Size(270, 36);
            this._price_all_form_buy.TabIndex = 999;
            this._price_all_form_buy.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PT Bold Heading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(120, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 37);
            this.label5.TabIndex = 16;
            this.label5.Text = "الاجمالي";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PT Bold Heading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(129, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "المدفوع";
            // 
            // _paid_up_form_buy
            // 
            this._paid_up_form_buy.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._paid_up_form_buy.Location = new System.Drawing.Point(27, 167);
            this._paid_up_form_buy.Name = "_paid_up_form_buy";
            this._paid_up_form_buy.Size = new System.Drawing.Size(270, 36);
            this._paid_up_form_buy.TabIndex = 0;
            this._paid_up_form_buy.TextChanged += new System.EventHandler(this._paid_up_form_buy_TextChanged);
            this._paid_up_form_buy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._paid_up_form_buy_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PT Bold Heading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(120, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 37);
            this.label2.TabIndex = 20;
            this.label2.Text = "المتبقي";
            // 
            // _Residual_form_buy
            // 
            this._Residual_form_buy.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Residual_form_buy.Location = new System.Drawing.Point(27, 273);
            this._Residual_form_buy.Name = "_Residual_form_buy";
            this._Residual_form_buy.ReadOnly = true;
            this._Residual_form_buy.Size = new System.Drawing.Size(270, 36);
            this._Residual_form_buy.TabIndex = 9999;
            this._Residual_form_buy.TabStop = false;
            // 
            // _ok_form_buy
            // 
            this._ok_form_buy.Location = new System.Drawing.Point(105, 326);
            this._ok_form_buy.Name = "_ok_form_buy";
            this._ok_form_buy.Size = new System.Drawing.Size(103, 47);
            this._ok_form_buy.TabIndex = 10000;
            this._ok_form_buy.Text = "موافق";
            this._ok_form_buy.UseVisualStyleBackColor = true;
            this._ok_form_buy.Click += new System.EventHandler(this._ok_form_buy_Click);
            // 
            // Form_buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 398);
            this.Controls.Add(this._ok_form_buy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._Residual_form_buy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._paid_up_form_buy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._price_all_form_buy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_buy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_buy";
            this.Load += new System.EventHandler(this.Form_buy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox _price_all_form_buy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _paid_up_form_buy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _Residual_form_buy;
        private System.Windows.Forms.Button _ok_form_buy;
    }
}