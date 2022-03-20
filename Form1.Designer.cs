namespace trigonometric
{
    partial class Form1
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
            this.cal_mode = new System.Windows.Forms.GroupBox();
            this.sin = new System.Windows.Forms.RadioButton();
            this.cos = new System.Windows.Forms.RadioButton();
            this.tan = new System.Windows.Forms.RadioButton();
            this.angle_mode = new System.Windows.Forms.GroupBox();
            this.deg = new System.Windows.Forms.RadioButton();
            this.rad = new System.Windows.Forms.RadioButton();
            this.angle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cal_start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cal_result = new System.Windows.Forms.TextBox();
            this.cal_mode.SuspendLayout();
            this.angle_mode.SuspendLayout();
            this.SuspendLayout();
            // 
            // cal_mode
            // 
            this.cal_mode.Controls.Add(this.tan);
            this.cal_mode.Controls.Add(this.cos);
            this.cal_mode.Controls.Add(this.sin);
            this.cal_mode.Location = new System.Drawing.Point(238, 28);
            this.cal_mode.Name = "cal_mode";
            this.cal_mode.Size = new System.Drawing.Size(93, 105);
            this.cal_mode.TabIndex = 0;
            this.cal_mode.TabStop = false;
            this.cal_mode.Text = "計算モード";
            // 
            // sin
            // 
            this.sin.AutoSize = true;
            this.sin.Location = new System.Drawing.Point(19, 22);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(40, 19);
            this.sin.TabIndex = 0;
            this.sin.TabStop = true;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            // 
            // cos
            // 
            this.cos.AutoSize = true;
            this.cos.Location = new System.Drawing.Point(19, 47);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(43, 19);
            this.cos.TabIndex = 1;
            this.cos.TabStop = true;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            // 
            // tan
            // 
            this.tan.AutoSize = true;
            this.tan.Location = new System.Drawing.Point(19, 72);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(42, 19);
            this.tan.TabIndex = 2;
            this.tan.TabStop = true;
            this.tan.Text = "tan";
            this.tan.UseVisualStyleBackColor = true;
            // 
            // angle_mode
            // 
            this.angle_mode.Controls.Add(this.rad);
            this.angle_mode.Controls.Add(this.deg);
            this.angle_mode.Location = new System.Drawing.Point(139, 28);
            this.angle_mode.Name = "angle_mode";
            this.angle_mode.Size = new System.Drawing.Size(93, 105);
            this.angle_mode.TabIndex = 1;
            this.angle_mode.TabStop = false;
            this.angle_mode.Text = "角度単位設定";
            // 
            // deg
            // 
            this.deg.AutoSize = true;
            this.deg.Location = new System.Drawing.Point(19, 30);
            this.deg.Name = "deg";
            this.deg.Size = new System.Drawing.Size(61, 19);
            this.deg.TabIndex = 0;
            this.deg.TabStop = true;
            this.deg.Text = "度数法";
            this.deg.UseVisualStyleBackColor = true;
            // 
            // rad
            // 
            this.rad.AutoSize = true;
            this.rad.Location = new System.Drawing.Point(19, 66);
            this.rad.Name = "rad";
            this.rad.Size = new System.Drawing.Size(61, 19);
            this.rad.TabIndex = 1;
            this.rad.TabStop = true;
            this.rad.Text = "弧度法";
            this.rad.UseVisualStyleBackColor = true;
            // 
            // angle
            // 
            this.angle.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.angle.Location = new System.Drawing.Point(12, 54);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(121, 23);
            this.angle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "角度";
            // 
            // cal_start
            // 
            this.cal_start.Location = new System.Drawing.Point(12, 100);
            this.cal_start.Name = "cal_start";
            this.cal_start.Size = new System.Drawing.Size(121, 23);
            this.cal_start.TabIndex = 4;
            this.cal_start.Text = "計算開始";
            this.cal_start.UseVisualStyleBackColor = true;
            this.cal_start.Click += new System.EventHandler(this.cal_start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "計算結果";
            // 
            // cal_result
            // 
            this.cal_result.Location = new System.Drawing.Point(73, 139);
            this.cal_result.Name = "cal_result";
            this.cal_result.ReadOnly = true;
            this.cal_result.Size = new System.Drawing.Size(258, 23);
            this.cal_result.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 174);
            this.Controls.Add(this.cal_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cal_start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.angle_mode);
            this.Controls.Add(this.cal_mode);
            this.Name = "Form1";
            this.Text = "三角関数近似計算";
            this.cal_mode.ResumeLayout(false);
            this.cal_mode.PerformLayout();
            this.angle_mode.ResumeLayout(false);
            this.angle_mode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox cal_mode;
        private RadioButton tan;
        private RadioButton cos;
        private RadioButton sin;
        private GroupBox angle_mode;
        private RadioButton rad;
        private RadioButton deg;
        private TextBox angle;
        private Label label1;
        private Button cal_start;
        private Label label2;
        private TextBox cal_result;
    }
}