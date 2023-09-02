namespace Math_Game_By_Using_C_
{
    partial class StorageData
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOperation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAnswerStyle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuestionNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumOfRight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumOfWrong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGameTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.BackColor = System.Drawing.Color.Salmon;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnLevel,
            this.columnOperation,
            this.columnAnswerStyle,
            this.columnQuestionNumber,
            this.columnNumOfRight,
            this.columnNumOfWrong,
            this.columnGameTime});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(959, 526);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnLevel
            // 
            this.columnLevel.Text = "Level";
            this.columnLevel.Width = 80;
            // 
            // columnOperation
            // 
            this.columnOperation.Text = "Operation";
            this.columnOperation.Width = 126;
            // 
            // columnAnswerStyle
            // 
            this.columnAnswerStyle.Text = "Answer Style";
            this.columnAnswerStyle.Width = 148;
            // 
            // columnQuestionNumber
            // 
            this.columnQuestionNumber.Text = "Questions Number";
            this.columnQuestionNumber.Width = 183;
            // 
            // columnNumOfRight
            // 
            this.columnNumOfRight.Text = "Right Answer";
            this.columnNumOfRight.Width = 140;
            // 
            // columnNumOfWrong
            // 
            this.columnNumOfWrong.Text = "Wrong Answer";
            this.columnNumOfWrong.Width = 151;
            // 
            // columnGameTime
            // 
            this.columnGameTime.Text = "Game Time";
            this.columnGameTime.Width = 126;
            // 
            // StorageData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 550);
            this.Controls.Add(this.listView1);
            this.Name = "StorageData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data";
            this.Load += new System.EventHandler(this.StorageData_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnLevel;
        private System.Windows.Forms.ColumnHeader columnOperation;
        private System.Windows.Forms.ColumnHeader columnAnswerStyle;
        private System.Windows.Forms.ColumnHeader columnQuestionNumber;
        private System.Windows.Forms.ColumnHeader columnNumOfRight;
        private System.Windows.Forms.ColumnHeader columnNumOfWrong;
        private System.Windows.Forms.ColumnHeader columnGameTime;
    }
}