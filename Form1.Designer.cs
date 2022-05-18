
namespace winform_test
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.번호 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.이름 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.년식 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.가격 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.도어 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDoor = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Modify = new System.Windows.Forms.Button();
            this.Qual_Search = new System.Windows.Forms.Button();
            this.AllSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.번호,
            this.이름,
            this.년식,
            this.가격,
            this.도어});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(327, 149);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // 번호
            // 
            this.번호.Text = "번호";
            this.번호.Width = 41;
            // 
            // 이름
            // 
            this.이름.Text = "이름";
            this.이름.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.이름.Width = 81;
            // 
            // 년식
            // 
            this.년식.Text = "년식";
            this.년식.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.년식.Width = 54;
            // 
            // 가격
            // 
            this.가격.Text = "가격";
            this.가격.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.가격.Width = 93;
            // 
            // 도어
            // 
            this.도어.Text = "도어";
            this.도어.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.도어.Width = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "이 름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "년 식";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "가 격";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "도 어";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(56, 180);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(85, 21);
            this.txtName.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(56, 206);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(85, 21);
            this.txtYear.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(56, 231);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(85, 21);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtDoor
            // 
            this.txtDoor.Location = new System.Drawing.Point(56, 255);
            this.txtDoor.Name = "txtDoor";
            this.txtDoor.Size = new System.Drawing.Size(85, 21);
            this.txtDoor.TabIndex = 8;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(250, 178);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 9;
            this.Save.Text = "저 장";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Modify
            // 
            this.Modify.Location = new System.Drawing.Point(250, 204);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(75, 23);
            this.Modify.TabIndex = 10;
            this.Modify.Text = "수 정";
            this.Modify.UseVisualStyleBackColor = true;
            this.Modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // button3
            // 
            this.Qual_Search.Location = new System.Drawing.Point(250, 229);
            this.Qual_Search.Name = "button3";
            this.Qual_Search.Size = new System.Drawing.Size(75, 23);
            this.Qual_Search.TabIndex = 11;
            this.Qual_Search.Text = "조건검색";
            this.Qual_Search.UseVisualStyleBackColor = true;
            this.Qual_Search.Click += new System.EventHandler(this.Qual_Search_Click);
            // 
            // button4
            // 
            this.AllSearch.Location = new System.Drawing.Point(250, 253);
            this.AllSearch.Name = "button4";
            this.AllSearch.Size = new System.Drawing.Size(75, 23);
            this.AllSearch.TabIndex = 12;
            this.AllSearch.Text = "전체검색";
            this.AllSearch.UseVisualStyleBackColor = true;
            this.AllSearch.Click += new System.EventHandler(this.AllSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 285);
            this.Controls.Add(this.AllSearch);
            this.Controls.Add(this.Qual_Search);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.txtDoor);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDoor;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.Button Qual_Search;
        private System.Windows.Forms.Button AllSearch;
        private System.Windows.Forms.ColumnHeader 번호;
        private System.Windows.Forms.ColumnHeader 이름;
        private System.Windows.Forms.ColumnHeader 년식;
        private System.Windows.Forms.ColumnHeader 가격;
        private System.Windows.Forms.ColumnHeader 도어;
    }
}

