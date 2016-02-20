using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MyRegularExpressionTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if(txtSentences.Text == " ")
            {
                MessageBox.Show("검색에 사용할 문장을 입력해 주세요");
                txtSentences.Focus();
                return;
            }
            else if(txtInputExpressions.Text ==" ")
            {
                MessageBox.Show("검색에 사용할 정규표현식을 입력해주세요");
                txtInputExpressions.Focus();
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckPattern(txtSentences.Text.Trim(),txtInputExpressions.Text.Trim(), RegexOptions.Multiline);
            if(Count ==1)
            {

            }
        }
        private void CheckPattern(string inputString, string strPattern, RegexOptions options)
        {
            MatchCollection matches = Regex.Matches(inputString, strPattern, options);
            txtResult.AppendText("\r\n 입력된 문장은 아래와 같습니다.");
            txtResult.AppendText("\r\n" + inputString);
            txtResult.AppendText("\r\n" + "********************************");
            txtResult.AppendText("\r\n  위 문장에서 입력된 패턴과 일치 회수는" + matches.Count.ToString() + "회가 발생");

            foreach(Match match in matches)
            {
                txtResult.AppendText("\r\n" + match.ToString() + " 이" + match.Index.ToString() + 
                    "위치(인덱스 번호) 에서 검색되었습니다.");
            }

        }
    }

    
}
