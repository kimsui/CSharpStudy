namespace MyRegularExpressionTool
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInputExpressions = new System.Windows.Forms.TextBox();
            this.txtSentences = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "졍규표현식 입력하기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "체크할 문장 입력하기";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "결과 보여주기";
            // 
            // txtInputExpressions
            // 
            this.txtInputExpressions.Location = new System.Drawing.Point(44, 33);
            this.txtInputExpressions.Multiline = true;
            this.txtInputExpressions.Name = "txtInputExpressions";
            this.txtInputExpressions.Size = new System.Drawing.Size(398, 72);
            this.txtInputExpressions.TabIndex = 3;
            // 
            // txtSentences
            // 
            this.txtSentences.Location = new System.Drawing.Point(44, 123);
            this.txtSentences.Multiline = true;
            this.txtSentences.Name = "txtSentences";
            this.txtSentences.Size = new System.Drawing.Size(398, 70);
            this.txtSentences.TabIndex = 4;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtResult.ForeColor = System.Drawing.Color.White;
            this.txtResult.Location = new System.Drawing.Point(44, 312);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(398, 116);
            this.txtResult.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSentences);
            this.Controls.Add(this.txtInputExpressions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInputExpressions;
        private System.Windows.Forms.TextBox txtSentences;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button button1;
    }
}

