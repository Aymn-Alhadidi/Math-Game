namespace Math_Game_By_Using_C_
{
    partial class Form1
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
            this.lblTheMainTextOfGame = new System.Windows.Forms.Label();
            this.gbLevel = new System.Windows.Forms.GroupBox();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.rbMeddium = new System.Windows.Forms.RadioButton();
            this.gbQuestionNumber = new System.Windows.Forms.GroupBox();
            this.Numberical_QuestionNumber = new System.Windows.Forms.NumericUpDown();
            this.btnPauseGame = new System.Windows.Forms.Button();
            this.btnEndGame = new System.Windows.Forms.Button();
            this.gbOperation = new System.Windows.Forms.GroupBox();
            this.rbDivision = new System.Windows.Forms.RadioButton();
            this.rbMultiplication = new System.Windows.Forms.RadioButton();
            this.rbSubtraction = new System.Windows.Forms.RadioButton();
            this.rbAddition = new System.Windows.Forms.RadioButton();
            this.rbMixed = new System.Windows.Forms.RadioButton();
            this.gbQuestionStyle = new System.Windows.Forms.GroupBox();
            this.rbOptionsStyle = new System.Windows.Forms.RadioButton();
            this.rbWriteAnswerStyle = new System.Windows.Forms.RadioButton();
            this.gbTime = new System.Windows.Forms.GroupBox();
            this.txtSeconds = new System.Windows.Forms.MaskedTextBox();
            this.txtMinutes = new System.Windows.Forms.MaskedTextBox();
            this.chkIsWithTime = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbGameTime = new System.Windows.Forms.Label();
            this.lbGameQuestionNumber = new System.Windows.Forms.Label();
            this.lbQuestionStyle = new System.Windows.Forms.Label();
            this.lbOperation = new System.Windows.Forms.Label();
            this.lbLevel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTimeLeft = new System.Windows.Forms.Label();
            this.lbWrongQuestion = new System.Windows.Forms.Label();
            this.lbRightQuestion = new System.Windows.Forms.Label();
            this.lbGameStatus = new System.Windows.Forms.Label();
            this.lbQuestionNumber = new System.Windows.Forms.Label();
            this.GameInfoError = new System.Windows.Forms.ErrorProvider(this.components);
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.btnData = new System.Windows.Forms.Button();
            this.gbLevel.SuspendLayout();
            this.gbQuestionNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numberical_QuestionNumber)).BeginInit();
            this.gbOperation.SuspendLayout();
            this.gbQuestionStyle.SuspendLayout();
            this.gbTime.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameInfoError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTheMainTextOfGame
            // 
            this.lblTheMainTextOfGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheMainTextOfGame.Location = new System.Drawing.Point(441, 48);
            this.lblTheMainTextOfGame.Name = "lblTheMainTextOfGame";
            this.lblTheMainTextOfGame.Size = new System.Drawing.Size(261, 100);
            this.lblTheMainTextOfGame.TabIndex = 0;
            this.lblTheMainTextOfGame.Text = "The Game Did Not Start";
            this.lblTheMainTextOfGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbLevel
            // 
            this.gbLevel.Controls.Add(this.rbCustom);
            this.gbLevel.Controls.Add(this.rbEasy);
            this.gbLevel.Controls.Add(this.rbHard);
            this.gbLevel.Controls.Add(this.rbMeddium);
            this.gbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLevel.Location = new System.Drawing.Point(33, 35);
            this.gbLevel.Name = "gbLevel";
            this.gbLevel.Size = new System.Drawing.Size(166, 379);
            this.gbLevel.TabIndex = 1;
            this.gbLevel.TabStop = false;
            this.gbLevel.Text = "Level";
            // 
            // rbCustom
            // 
            this.rbCustom.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbCustom.BackColor = System.Drawing.Color.Tomato;
            this.rbCustom.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCustom.Location = new System.Drawing.Point(18, 294);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(128, 62);
            this.rbCustom.TabIndex = 15;
            this.rbCustom.TabStop = true;
            this.rbCustom.Text = "Custom";
            this.rbCustom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbCustom.UseVisualStyleBackColor = false;
            this.rbCustom.CheckedChanged += new System.EventHandler(this.rbCustom_CheckedChanged);
            this.rbCustom.Click += new System.EventHandler(this.rbCustom_Click);
            // 
            // rbEasy
            // 
            this.rbEasy.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbEasy.BackColor = System.Drawing.Color.Tomato;
            this.rbEasy.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEasy.Location = new System.Drawing.Point(18, 204);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(128, 62);
            this.rbEasy.TabIndex = 15;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "Easy 0-10";
            this.rbEasy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbEasy.UseVisualStyleBackColor = false;
            this.rbEasy.CheckedChanged += new System.EventHandler(this.rbEasy_CheckedChanged);
            // 
            // rbHard
            // 
            this.rbHard.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbHard.BackColor = System.Drawing.Color.Tomato;
            this.rbHard.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHard.Location = new System.Drawing.Point(18, 24);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(128, 62);
            this.rbHard.TabIndex = 15;
            this.rbHard.TabStop = true;
            this.rbHard.Text = "Hard 0-100";
            this.rbHard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbHard.UseVisualStyleBackColor = false;
            this.rbHard.CheckedChanged += new System.EventHandler(this.rbHard_CheckedChanged);
            // 
            // rbMeddium
            // 
            this.rbMeddium.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbMeddium.BackColor = System.Drawing.Color.Tomato;
            this.rbMeddium.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMeddium.Location = new System.Drawing.Point(18, 114);
            this.rbMeddium.Name = "rbMeddium";
            this.rbMeddium.Size = new System.Drawing.Size(128, 62);
            this.rbMeddium.TabIndex = 14;
            this.rbMeddium.TabStop = true;
            this.rbMeddium.Text = "Meddium 0-50";
            this.rbMeddium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbMeddium.UseVisualStyleBackColor = false;
            this.rbMeddium.CheckedChanged += new System.EventHandler(this.rbMeddium_CheckedChanged);
            // 
            // gbQuestionNumber
            // 
            this.gbQuestionNumber.Controls.Add(this.Numberical_QuestionNumber);
            this.gbQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQuestionNumber.Location = new System.Drawing.Point(29, 449);
            this.gbQuestionNumber.Name = "gbQuestionNumber";
            this.gbQuestionNumber.Size = new System.Drawing.Size(170, 110);
            this.gbQuestionNumber.TabIndex = 2;
            this.gbQuestionNumber.TabStop = false;
            this.gbQuestionNumber.Text = "Questions Number";
            // 
            // Numberical_QuestionNumber
            // 
            this.Numberical_QuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numberical_QuestionNumber.Location = new System.Drawing.Point(36, 44);
            this.Numberical_QuestionNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numberical_QuestionNumber.Name = "Numberical_QuestionNumber";
            this.Numberical_QuestionNumber.Size = new System.Drawing.Size(102, 34);
            this.Numberical_QuestionNumber.TabIndex = 3;
            this.Numberical_QuestionNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Numberical_QuestionNumber.ValueChanged += new System.EventHandler(this.Numberical_QuestionNumber_ValueChanged);
            // 
            // btnPauseGame
            // 
            this.btnPauseGame.BackColor = System.Drawing.Color.Tomato;
            this.btnPauseGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPauseGame.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPauseGame.Location = new System.Drawing.Point(51, 648);
            this.btnPauseGame.Name = "btnPauseGame";
            this.btnPauseGame.Size = new System.Drawing.Size(128, 62);
            this.btnPauseGame.TabIndex = 6;
            this.btnPauseGame.Text = "Pause Game";
            this.btnPauseGame.UseVisualStyleBackColor = false;
            this.btnPauseGame.Click += new System.EventHandler(this.btnPauseGame_Click);
            // 
            // btnEndGame
            // 
            this.btnEndGame.BackColor = System.Drawing.Color.Tomato;
            this.btnEndGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEndGame.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndGame.Location = new System.Drawing.Point(51, 722);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(128, 62);
            this.btnEndGame.TabIndex = 7;
            this.btnEndGame.Text = "End Game";
            this.btnEndGame.UseVisualStyleBackColor = false;
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // gbOperation
            // 
            this.gbOperation.Controls.Add(this.rbDivision);
            this.gbOperation.Controls.Add(this.rbMultiplication);
            this.gbOperation.Controls.Add(this.rbSubtraction);
            this.gbOperation.Controls.Add(this.rbAddition);
            this.gbOperation.Controls.Add(this.rbMixed);
            this.gbOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOperation.Location = new System.Drawing.Point(923, 35);
            this.gbOperation.Name = "gbOperation";
            this.gbOperation.Size = new System.Drawing.Size(174, 280);
            this.gbOperation.TabIndex = 8;
            this.gbOperation.TabStop = false;
            this.gbOperation.Text = "Operation";
            // 
            // rbDivision
            // 
            this.rbDivision.AutoSize = true;
            this.rbDivision.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDivision.Location = new System.Drawing.Point(15, 222);
            this.rbDivision.Name = "rbDivision";
            this.rbDivision.Size = new System.Drawing.Size(90, 23);
            this.rbDivision.TabIndex = 13;
            this.rbDivision.Text = "Division";
            this.rbDivision.UseVisualStyleBackColor = true;
            this.rbDivision.CheckedChanged += new System.EventHandler(this.rbDivision_CheckedChanged);
            // 
            // rbMultiplication
            // 
            this.rbMultiplication.AutoSize = true;
            this.rbMultiplication.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMultiplication.Location = new System.Drawing.Point(15, 178);
            this.rbMultiplication.Name = "rbMultiplication";
            this.rbMultiplication.Size = new System.Drawing.Size(133, 23);
            this.rbMultiplication.TabIndex = 12;
            this.rbMultiplication.Text = "MultiPlication";
            this.rbMultiplication.UseVisualStyleBackColor = true;
            this.rbMultiplication.CheckedChanged += new System.EventHandler(this.rbMultiplication_CheckedChanged);
            // 
            // rbSubtraction
            // 
            this.rbSubtraction.AutoSize = true;
            this.rbSubtraction.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSubtraction.Location = new System.Drawing.Point(13, 134);
            this.rbSubtraction.Name = "rbSubtraction";
            this.rbSubtraction.Size = new System.Drawing.Size(116, 23);
            this.rbSubtraction.TabIndex = 11;
            this.rbSubtraction.Text = "Subtraction";
            this.rbSubtraction.UseVisualStyleBackColor = true;
            this.rbSubtraction.CheckedChanged += new System.EventHandler(this.rbSubtraction_CheckedChanged);
            // 
            // rbAddition
            // 
            this.rbAddition.AutoSize = true;
            this.rbAddition.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAddition.Location = new System.Drawing.Point(15, 90);
            this.rbAddition.Name = "rbAddition";
            this.rbAddition.Size = new System.Drawing.Size(91, 23);
            this.rbAddition.TabIndex = 10;
            this.rbAddition.Text = "Addition";
            this.rbAddition.UseVisualStyleBackColor = true;
            this.rbAddition.CheckedChanged += new System.EventHandler(this.rbAddition_CheckedChanged);
            // 
            // rbMixed
            // 
            this.rbMixed.AutoSize = true;
            this.rbMixed.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMixed.Location = new System.Drawing.Point(15, 46);
            this.rbMixed.Name = "rbMixed";
            this.rbMixed.Size = new System.Drawing.Size(72, 23);
            this.rbMixed.TabIndex = 9;
            this.rbMixed.Text = "Mixed";
            this.rbMixed.UseVisualStyleBackColor = true;
            this.rbMixed.CheckedChanged += new System.EventHandler(this.rbMixed_CheckedChanged);
            // 
            // gbQuestionStyle
            // 
            this.gbQuestionStyle.Controls.Add(this.rbOptionsStyle);
            this.gbQuestionStyle.Controls.Add(this.rbWriteAnswerStyle);
            this.gbQuestionStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQuestionStyle.Location = new System.Drawing.Point(922, 344);
            this.gbQuestionStyle.Name = "gbQuestionStyle";
            this.gbQuestionStyle.Size = new System.Drawing.Size(173, 165);
            this.gbQuestionStyle.TabIndex = 9;
            this.gbQuestionStyle.TabStop = false;
            this.gbQuestionStyle.Text = "Questioin Style";
            // 
            // rbOptionsStyle
            // 
            this.rbOptionsStyle.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbOptionsStyle.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOptionsStyle.Location = new System.Drawing.Point(30, 105);
            this.rbOptionsStyle.Name = "rbOptionsStyle";
            this.rbOptionsStyle.Size = new System.Drawing.Size(111, 39);
            this.rbOptionsStyle.TabIndex = 15;
            this.rbOptionsStyle.Text = "Option Style";
            this.rbOptionsStyle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbOptionsStyle.UseVisualStyleBackColor = true;
            this.rbOptionsStyle.CheckedChanged += new System.EventHandler(this.rbOptionsStyle_CheckedChanged);
            // 
            // rbWriteAnswerStyle
            // 
            this.rbWriteAnswerStyle.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbWriteAnswerStyle.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWriteAnswerStyle.Location = new System.Drawing.Point(24, 33);
            this.rbWriteAnswerStyle.Name = "rbWriteAnswerStyle";
            this.rbWriteAnswerStyle.Size = new System.Drawing.Size(125, 61);
            this.rbWriteAnswerStyle.TabIndex = 14;
            this.rbWriteAnswerStyle.Text = "Write Ansewr Style";
            this.rbWriteAnswerStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbWriteAnswerStyle.UseVisualStyleBackColor = true;
            this.rbWriteAnswerStyle.CheckedChanged += new System.EventHandler(this.rbWriteAnswerStyle_CheckedChanged);
            // 
            // gbTime
            // 
            this.gbTime.Controls.Add(this.txtSeconds);
            this.gbTime.Controls.Add(this.txtMinutes);
            this.gbTime.Controls.Add(this.chkIsWithTime);
            this.gbTime.Controls.Add(this.label4);
            this.gbTime.Controls.Add(this.label3);
            this.gbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTime.Location = new System.Drawing.Point(923, 534);
            this.gbTime.Name = "gbTime";
            this.gbTime.Size = new System.Drawing.Size(173, 165);
            this.gbTime.TabIndex = 10;
            this.gbTime.TabStop = false;
            this.gbTime.Text = "Time";
            // 
            // txtSeconds
            // 
            this.txtSeconds.Enabled = false;
            this.txtSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeconds.Location = new System.Drawing.Point(112, 87);
            this.txtSeconds.Mask = "00";
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(55, 30);
            this.txtSeconds.TabIndex = 15;
            this.txtSeconds.Text = "00";
            this.txtSeconds.Validating += new System.ComponentModel.CancelEventHandler(this.txtSeconds_Validating);
            // 
            // txtMinutes
            // 
            this.txtMinutes.Enabled = false;
            this.txtMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutes.Location = new System.Drawing.Point(112, 40);
            this.txtMinutes.Mask = "00";
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(55, 30);
            this.txtMinutes.TabIndex = 14;
            this.txtMinutes.Text = "00";
            this.txtMinutes.Validating += new System.ComponentModel.CancelEventHandler(this.txtMinutes_Validating);
            // 
            // chkIsWithTime
            // 
            this.chkIsWithTime.AutoSize = true;
            this.chkIsWithTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsWithTime.Location = new System.Drawing.Point(23, 133);
            this.chkIsWithTime.Name = "chkIsWithTime";
            this.chkIsWithTime.Size = new System.Drawing.Size(133, 26);
            this.chkIsWithTime.TabIndex = 11;
            this.chkIsWithTime.Text = "With Time?";
            this.chkIsWithTime.UseVisualStyleBackColor = true;
            this.chkIsWithTime.CheckedChanged += new System.EventHandler(this.chkIsWithTime_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Seconds: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Minutes: ";
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Tomato;
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartGame.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(967, 723);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(128, 62);
            this.btnStartGame.TabIndex = 11;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbGameTime);
            this.groupBox1.Controls.Add(this.lbGameQuestionNumber);
            this.groupBox1.Controls.Add(this.lbQuestionStyle);
            this.groupBox1.Controls.Add(this.lbOperation);
            this.groupBox1.Controls.Add(this.lbLevel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(234, 429);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 356);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Info";
            // 
            // lbGameTime
            // 
            this.lbGameTime.AutoSize = true;
            this.lbGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameTime.Location = new System.Drawing.Point(23, 291);
            this.lbGameTime.Name = "lbGameTime";
            this.lbGameTime.Size = new System.Drawing.Size(136, 25);
            this.lbGameTime.TabIndex = 18;
            this.lbGameTime.Text = "Game Time: ";
            // 
            // lbGameQuestionNumber
            // 
            this.lbGameQuestionNumber.AutoSize = true;
            this.lbGameQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameQuestionNumber.Location = new System.Drawing.Point(23, 232);
            this.lbGameQuestionNumber.Name = "lbGameQuestionNumber";
            this.lbGameQuestionNumber.Size = new System.Drawing.Size(193, 25);
            this.lbGameQuestionNumber.TabIndex = 17;
            this.lbGameQuestionNumber.Text = "Question Number: ";
            // 
            // lbQuestionStyle
            // 
            this.lbQuestionStyle.AutoSize = true;
            this.lbQuestionStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestionStyle.Location = new System.Drawing.Point(23, 173);
            this.lbQuestionStyle.Name = "lbQuestionStyle";
            this.lbQuestionStyle.Size = new System.Drawing.Size(167, 25);
            this.lbQuestionStyle.TabIndex = 16;
            this.lbQuestionStyle.Text = "Question Style: ";
            // 
            // lbOperation
            // 
            this.lbOperation.AutoSize = true;
            this.lbOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOperation.Location = new System.Drawing.Point(23, 114);
            this.lbOperation.Name = "lbOperation";
            this.lbOperation.Size = new System.Drawing.Size(114, 25);
            this.lbOperation.TabIndex = 15;
            this.lbOperation.Text = "Operation:";
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.Location = new System.Drawing.Point(23, 55);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(77, 25);
            this.lbLevel.TabIndex = 14;
            this.lbLevel.Text = "Level: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTimeLeft);
            this.groupBox2.Controls.Add(this.lbWrongQuestion);
            this.groupBox2.Controls.Add(this.lbRightQuestion);
            this.groupBox2.Controls.Add(this.lbGameStatus);
            this.groupBox2.Controls.Add(this.lbQuestionNumber);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(577, 429);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 356);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game Info";
            // 
            // lbTimeLeft
            // 
            this.lbTimeLeft.AutoSize = true;
            this.lbTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeLeft.Location = new System.Drawing.Point(21, 291);
            this.lbTimeLeft.Name = "lbTimeLeft";
            this.lbTimeLeft.Size = new System.Drawing.Size(115, 25);
            this.lbTimeLeft.TabIndex = 22;
            this.lbTimeLeft.Text = "Time Left: ";
            // 
            // lbWrongQuestion
            // 
            this.lbWrongQuestion.AutoSize = true;
            this.lbWrongQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWrongQuestion.Location = new System.Drawing.Point(21, 232);
            this.lbWrongQuestion.Name = "lbWrongQuestion";
            this.lbWrongQuestion.Size = new System.Drawing.Size(182, 25);
            this.lbWrongQuestion.TabIndex = 22;
            this.lbWrongQuestion.Text = "Wrong Question: ";
            // 
            // lbRightQuestion
            // 
            this.lbRightQuestion.AutoSize = true;
            this.lbRightQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRightQuestion.Location = new System.Drawing.Point(21, 178);
            this.lbRightQuestion.Name = "lbRightQuestion";
            this.lbRightQuestion.Size = new System.Drawing.Size(167, 25);
            this.lbRightQuestion.TabIndex = 22;
            this.lbRightQuestion.Text = "Right Question: ";
            // 
            // lbGameStatus
            // 
            this.lbGameStatus.AutoSize = true;
            this.lbGameStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameStatus.Location = new System.Drawing.Point(21, 55);
            this.lbGameStatus.Name = "lbGameStatus";
            this.lbGameStatus.Size = new System.Drawing.Size(137, 25);
            this.lbGameStatus.TabIndex = 23;
            this.lbGameStatus.Text = "Game Status";
            // 
            // lbQuestionNumber
            // 
            this.lbQuestionNumber.AutoSize = true;
            this.lbQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestionNumber.Location = new System.Drawing.Point(21, 114);
            this.lbQuestionNumber.Name = "lbQuestionNumber";
            this.lbQuestionNumber.Size = new System.Drawing.Size(193, 25);
            this.lbQuestionNumber.TabIndex = 23;
            this.lbQuestionNumber.Text = "Question Number: ";
            // 
            // GameInfoError
            // 
            this.GameInfoError.ContainerControl = this;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.Color.Tomato;
            this.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnData.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnData.Location = new System.Drawing.Point(51, 574);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(128, 62);
            this.btnData.TabIndex = 14;
            this.btnData.Text = "Data";
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1121, 797);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.gbTime);
            this.Controls.Add(this.gbQuestionStyle);
            this.Controls.Add(this.gbOperation);
            this.Controls.Add(this.btnEndGame);
            this.Controls.Add(this.btnPauseGame);
            this.Controls.Add(this.gbQuestionNumber);
            this.Controls.Add(this.gbLevel);
            this.Controls.Add(this.lblTheMainTextOfGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbLevel.ResumeLayout(false);
            this.gbQuestionNumber.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Numberical_QuestionNumber)).EndInit();
            this.gbOperation.ResumeLayout(false);
            this.gbOperation.PerformLayout();
            this.gbQuestionStyle.ResumeLayout(false);
            this.gbTime.ResumeLayout(false);
            this.gbTime.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameInfoError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTheMainTextOfGame;
        private System.Windows.Forms.GroupBox gbLevel;
        private System.Windows.Forms.GroupBox gbQuestionNumber;
        private System.Windows.Forms.NumericUpDown Numberical_QuestionNumber;
        private System.Windows.Forms.Button btnPauseGame;
        private System.Windows.Forms.Button btnEndGame;
        private System.Windows.Forms.GroupBox gbOperation;
        private System.Windows.Forms.RadioButton rbDivision;
        private System.Windows.Forms.RadioButton rbMultiplication;
        private System.Windows.Forms.RadioButton rbSubtraction;
        private System.Windows.Forms.RadioButton rbAddition;
        private System.Windows.Forms.RadioButton rbMixed;
        private System.Windows.Forms.GroupBox gbQuestionStyle;
        private System.Windows.Forms.RadioButton rbOptionsStyle;
        private System.Windows.Forms.RadioButton rbWriteAnswerStyle;
        private System.Windows.Forms.GroupBox gbTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkIsWithTime;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbGameTime;
        private System.Windows.Forms.Label lbGameQuestionNumber;
        private System.Windows.Forms.Label lbQuestionStyle;
        private System.Windows.Forms.Label lbOperation;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.Label lbTimeLeft;
        private System.Windows.Forms.Label lbWrongQuestion;
        private System.Windows.Forms.Label lbRightQuestion;
        private System.Windows.Forms.Label lbGameStatus;
        private System.Windows.Forms.Label lbQuestionNumber;
        private System.Windows.Forms.ErrorProvider GameInfoError;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.RadioButton rbMeddium;
        private System.Windows.Forms.MaskedTextBox txtMinutes;
        private System.Windows.Forms.MaskedTextBox txtSeconds;
        private System.Windows.Forms.Button btnData;
    }
}

