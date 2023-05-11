namespace JogoDaForca.WinFormsApp
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
            imgForca = new PictureBox();
            imgCabeca = new PictureBox();
            imgCorpo = new PictureBox();
            imgBracoD = new PictureBox();
            imgBracoE = new PictureBox();
            imgPernaD = new PictureBox();
            imgPernaE = new PictureBox();
            label1 = new Label();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            btnE = new Button();
            btnF = new Button();
            btnG = new Button();
            btnH = new Button();
            btnI = new Button();
            btnJ = new Button();
            btnK = new Button();
            btnS = new Button();
            btnR = new Button();
            btnQ = new Button();
            btnP = new Button();
            btnO = new Button();
            btnN = new Button();
            btnM = new Button();
            btnL = new Button();
            btnT = new Button();
            btnCedilha = new Button();
            btnZ = new Button();
            btnY = new Button();
            btnX = new Button();
            btnW = new Button();
            btnV = new Button();
            btnU = new Button();
            btnNovoJogo = new Button();
            label2 = new Label();
            label3 = new Label();
            lblPalavra = new Label();
            pnlBotoes = new Panel();
            lblDica = new Label();
            statusMensagem = new StatusStrip();
            lblMensagemFinal = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)imgForca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCabeca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCorpo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgBracoD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgBracoE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgPernaD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgPernaE).BeginInit();
            pnlBotoes.SuspendLayout();
            statusMensagem.SuspendLayout();
            SuspendLayout();
            // 
            // imgForca
            // 
            imgForca.Image = Properties.Resources.forca;
            imgForca.Location = new Point(-23, 61);
            imgForca.Name = "imgForca";
            imgForca.Size = new Size(215, 268);
            imgForca.SizeMode = PictureBoxSizeMode.Zoom;
            imgForca.TabIndex = 0;
            imgForca.TabStop = false;
            // 
            // imgCabeca
            // 
            imgCabeca.Image = Properties.Resources.boneco;
            imgCabeca.Location = new Point(69, 126);
            imgCabeca.Name = "imgCabeca";
            imgCabeca.Size = new Size(112, 78);
            imgCabeca.SizeMode = PictureBoxSizeMode.Zoom;
            imgCabeca.TabIndex = 1;
            imgCabeca.TabStop = false;
            imgCabeca.Visible = false;
            // 
            // imgCorpo
            // 
            imgCorpo.BackColor = Color.Transparent;
            imgCorpo.Image = Properties.Resources.corpo;
            imgCorpo.Location = new Point(113, 201);
            imgCorpo.Name = "imgCorpo";
            imgCorpo.Size = new Size(26, 50);
            imgCorpo.SizeMode = PictureBoxSizeMode.Zoom;
            imgCorpo.TabIndex = 2;
            imgCorpo.TabStop = false;
            imgCorpo.Visible = false;
            // 
            // imgBracoD
            // 
            imgBracoD.BackColor = Color.Transparent;
            imgBracoD.Image = Properties.Resources.braco1;
            imgBracoD.Location = new Point(134, 201);
            imgBracoD.Name = "imgBracoD";
            imgBracoD.Size = new Size(47, 50);
            imgBracoD.SizeMode = PictureBoxSizeMode.Zoom;
            imgBracoD.TabIndex = 3;
            imgBracoD.TabStop = false;
            imgBracoD.Visible = false;
            // 
            // imgBracoE
            // 
            imgBracoE.Image = Properties.Resources.braco2;
            imgBracoE.Location = new Point(69, 201);
            imgBracoE.Name = "imgBracoE";
            imgBracoE.Size = new Size(48, 50);
            imgBracoE.SizeMode = PictureBoxSizeMode.Zoom;
            imgBracoE.TabIndex = 4;
            imgBracoE.TabStop = false;
            imgBracoE.Visible = false;
            // 
            // imgPernaD
            // 
            imgPernaD.Image = Properties.Resources.perna2;
            imgPernaD.Location = new Point(123, 248);
            imgPernaD.Name = "imgPernaD";
            imgPernaD.Size = new Size(58, 65);
            imgPernaD.SizeMode = PictureBoxSizeMode.Zoom;
            imgPernaD.TabIndex = 5;
            imgPernaD.TabStop = false;
            imgPernaD.Visible = false;
            // 
            // imgPernaE
            // 
            imgPernaE.Image = Properties.Resources.perna1;
            imgPernaE.Location = new Point(69, 248);
            imgPernaE.Name = "imgPernaE";
            imgPernaE.Size = new Size(59, 65);
            imgPernaE.SizeMode = PictureBoxSizeMode.Zoom;
            imgPernaE.TabIndex = 7;
            imgPernaE.TabStop = false;
            imgPernaE.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("TASTY DONUTS", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(191, 27);
            label1.TabIndex = 8;
            label1.Text = "JOGO DA FORCA";
            // 
            // btnA
            // 
            btnA.BackColor = Color.Sienna;
            btnA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnA.ForeColor = SystemColors.ButtonFace;
            btnA.Location = new Point(13, 14);
            btnA.Name = "btnA";
            btnA.Size = new Size(37, 32);
            btnA.TabIndex = 9;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = false;
            // 
            // btnB
            // 
            btnB.BackColor = Color.Sienna;
            btnB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnB.ForeColor = SystemColors.ButtonFace;
            btnB.Location = new Point(56, 14);
            btnB.Name = "btnB";
            btnB.Size = new Size(37, 32);
            btnB.TabIndex = 10;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = false;
            // 
            // btnC
            // 
            btnC.BackColor = Color.Sienna;
            btnC.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnC.ForeColor = SystemColors.ButtonFace;
            btnC.Location = new Point(99, 14);
            btnC.Name = "btnC";
            btnC.Size = new Size(37, 32);
            btnC.TabIndex = 11;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            // 
            // btnD
            // 
            btnD.BackColor = Color.Sienna;
            btnD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnD.ForeColor = SystemColors.ButtonFace;
            btnD.Location = new Point(142, 14);
            btnD.Name = "btnD";
            btnD.Size = new Size(37, 32);
            btnD.TabIndex = 12;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = false;
            // 
            // btnE
            // 
            btnE.BackColor = Color.Sienna;
            btnE.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnE.ForeColor = SystemColors.ButtonFace;
            btnE.Location = new Point(185, 14);
            btnE.Name = "btnE";
            btnE.Size = new Size(37, 32);
            btnE.TabIndex = 13;
            btnE.Text = "E";
            btnE.UseVisualStyleBackColor = false;
            // 
            // btnF
            // 
            btnF.BackColor = Color.Sienna;
            btnF.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnF.ForeColor = SystemColors.ButtonFace;
            btnF.Location = new Point(228, 14);
            btnF.Name = "btnF";
            btnF.Size = new Size(37, 32);
            btnF.TabIndex = 14;
            btnF.Text = "F";
            btnF.UseVisualStyleBackColor = false;
            // 
            // btnG
            // 
            btnG.BackColor = Color.Sienna;
            btnG.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnG.ForeColor = SystemColors.ButtonFace;
            btnG.Location = new Point(271, 14);
            btnG.Name = "btnG";
            btnG.Size = new Size(37, 32);
            btnG.TabIndex = 15;
            btnG.Text = "G";
            btnG.UseVisualStyleBackColor = false;
            // 
            // btnH
            // 
            btnH.BackColor = Color.Sienna;
            btnH.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnH.ForeColor = SystemColors.ButtonFace;
            btnH.Location = new Point(314, 14);
            btnH.Name = "btnH";
            btnH.Size = new Size(37, 32);
            btnH.TabIndex = 16;
            btnH.Text = "H";
            btnH.UseVisualStyleBackColor = false;
            // 
            // btnI
            // 
            btnI.BackColor = Color.Sienna;
            btnI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnI.ForeColor = SystemColors.ButtonFace;
            btnI.Location = new Point(357, 14);
            btnI.Name = "btnI";
            btnI.Size = new Size(37, 32);
            btnI.TabIndex = 17;
            btnI.Text = "I";
            btnI.UseVisualStyleBackColor = false;
            // 
            // btnJ
            // 
            btnJ.BackColor = Color.Sienna;
            btnJ.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnJ.ForeColor = SystemColors.ButtonFace;
            btnJ.Location = new Point(400, 14);
            btnJ.Name = "btnJ";
            btnJ.Size = new Size(37, 32);
            btnJ.TabIndex = 18;
            btnJ.Text = "J";
            btnJ.UseVisualStyleBackColor = false;
            // 
            // btnK
            // 
            btnK.BackColor = Color.Sienna;
            btnK.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnK.ForeColor = SystemColors.ButtonFace;
            btnK.Location = new Point(35, 52);
            btnK.Name = "btnK";
            btnK.Size = new Size(37, 32);
            btnK.TabIndex = 19;
            btnK.Text = "K";
            btnK.UseVisualStyleBackColor = false;
            // 
            // btnS
            // 
            btnS.BackColor = Color.Sienna;
            btnS.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnS.ForeColor = SystemColors.ButtonFace;
            btnS.Location = new Point(379, 52);
            btnS.Name = "btnS";
            btnS.Size = new Size(37, 32);
            btnS.TabIndex = 27;
            btnS.Text = "S";
            btnS.UseVisualStyleBackColor = false;
            // 
            // btnR
            // 
            btnR.BackColor = Color.Sienna;
            btnR.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnR.ForeColor = SystemColors.ButtonFace;
            btnR.Location = new Point(336, 52);
            btnR.Name = "btnR";
            btnR.Size = new Size(37, 32);
            btnR.TabIndex = 26;
            btnR.Text = "R";
            btnR.UseVisualStyleBackColor = false;
            // 
            // btnQ
            // 
            btnQ.BackColor = Color.Sienna;
            btnQ.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQ.ForeColor = SystemColors.ButtonFace;
            btnQ.Location = new Point(293, 52);
            btnQ.Name = "btnQ";
            btnQ.Size = new Size(37, 32);
            btnQ.TabIndex = 25;
            btnQ.Text = "Q";
            btnQ.UseVisualStyleBackColor = false;
            // 
            // btnP
            // 
            btnP.BackColor = Color.Sienna;
            btnP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnP.ForeColor = SystemColors.ButtonFace;
            btnP.Location = new Point(250, 52);
            btnP.Name = "btnP";
            btnP.Size = new Size(37, 32);
            btnP.TabIndex = 24;
            btnP.Text = "P";
            btnP.UseVisualStyleBackColor = false;
            // 
            // btnO
            // 
            btnO.BackColor = Color.Sienna;
            btnO.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnO.ForeColor = SystemColors.ButtonFace;
            btnO.Location = new Point(207, 52);
            btnO.Name = "btnO";
            btnO.Size = new Size(37, 32);
            btnO.TabIndex = 23;
            btnO.Text = "O";
            btnO.UseVisualStyleBackColor = false;
            // 
            // btnN
            // 
            btnN.BackColor = Color.Sienna;
            btnN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnN.ForeColor = SystemColors.ButtonFace;
            btnN.Location = new Point(164, 52);
            btnN.Name = "btnN";
            btnN.Size = new Size(37, 32);
            btnN.TabIndex = 22;
            btnN.Text = "N";
            btnN.UseVisualStyleBackColor = false;
            // 
            // btnM
            // 
            btnM.BackColor = Color.Sienna;
            btnM.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnM.ForeColor = SystemColors.ButtonFace;
            btnM.Location = new Point(121, 52);
            btnM.Name = "btnM";
            btnM.Size = new Size(37, 32);
            btnM.TabIndex = 21;
            btnM.Text = "M";
            btnM.UseVisualStyleBackColor = false;
            // 
            // btnL
            // 
            btnL.BackColor = Color.Sienna;
            btnL.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnL.ForeColor = SystemColors.ButtonFace;
            btnL.Location = new Point(78, 52);
            btnL.Name = "btnL";
            btnL.Size = new Size(37, 32);
            btnL.TabIndex = 20;
            btnL.Text = "L";
            btnL.UseVisualStyleBackColor = false;
            // 
            // btnT
            // 
            btnT.BackColor = Color.Sienna;
            btnT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnT.ForeColor = SystemColors.ButtonFace;
            btnT.Location = new Point(56, 90);
            btnT.Name = "btnT";
            btnT.Size = new Size(37, 32);
            btnT.TabIndex = 28;
            btnT.Text = "T";
            btnT.UseVisualStyleBackColor = false;
            // 
            // btnCedilha
            // 
            btnCedilha.BackColor = Color.Sienna;
            btnCedilha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCedilha.ForeColor = SystemColors.ButtonFace;
            btnCedilha.Location = new Point(357, 90);
            btnCedilha.Name = "btnCedilha";
            btnCedilha.Size = new Size(37, 32);
            btnCedilha.TabIndex = 35;
            btnCedilha.Text = "Ç";
            btnCedilha.UseVisualStyleBackColor = false;
            // 
            // btnZ
            // 
            btnZ.BackColor = Color.Sienna;
            btnZ.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnZ.ForeColor = SystemColors.ButtonFace;
            btnZ.Location = new Point(314, 90);
            btnZ.Name = "btnZ";
            btnZ.Size = new Size(37, 32);
            btnZ.TabIndex = 34;
            btnZ.Text = "Z";
            btnZ.UseVisualStyleBackColor = false;
            // 
            // btnY
            // 
            btnY.BackColor = Color.Sienna;
            btnY.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnY.ForeColor = SystemColors.ButtonFace;
            btnY.Location = new Point(271, 90);
            btnY.Name = "btnY";
            btnY.Size = new Size(37, 32);
            btnY.TabIndex = 33;
            btnY.Text = "Y";
            btnY.UseVisualStyleBackColor = false;
            // 
            // btnX
            // 
            btnX.BackColor = Color.Sienna;
            btnX.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnX.ForeColor = SystemColors.ButtonFace;
            btnX.Location = new Point(228, 90);
            btnX.Name = "btnX";
            btnX.Size = new Size(37, 32);
            btnX.TabIndex = 32;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = false;
            // 
            // btnW
            // 
            btnW.BackColor = Color.Sienna;
            btnW.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnW.ForeColor = SystemColors.ButtonFace;
            btnW.Location = new Point(185, 90);
            btnW.Name = "btnW";
            btnW.Size = new Size(37, 32);
            btnW.TabIndex = 31;
            btnW.Text = "W";
            btnW.UseVisualStyleBackColor = false;
            // 
            // btnV
            // 
            btnV.BackColor = Color.Sienna;
            btnV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnV.ForeColor = SystemColors.ButtonFace;
            btnV.Location = new Point(142, 90);
            btnV.Name = "btnV";
            btnV.Size = new Size(37, 32);
            btnV.TabIndex = 30;
            btnV.Text = "V";
            btnV.UseVisualStyleBackColor = false;
            // 
            // btnU
            // 
            btnU.BackColor = Color.Sienna;
            btnU.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnU.ForeColor = SystemColors.ButtonFace;
            btnU.Location = new Point(99, 90);
            btnU.Name = "btnU";
            btnU.Size = new Size(37, 32);
            btnU.TabIndex = 29;
            btnU.Text = "U";
            btnU.UseVisualStyleBackColor = false;
            // 
            // btnNovoJogo
            // 
            btnNovoJogo.BackColor = Color.Peru;
            btnNovoJogo.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNovoJogo.ForeColor = SystemColors.ButtonHighlight;
            btnNovoJogo.Location = new Point(548, 174);
            btnNovoJogo.Name = "btnNovoJogo";
            btnNovoJogo.Size = new Size(96, 30);
            btnNovoJogo.TabIndex = 37;
            btnNovoJogo.Text = "NOVO JOGO";
            btnNovoJogo.UseVisualStyleBackColor = false;
            btnNovoJogo.Click += ReiniciarJogo;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("TASTY DONUTS", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(478, 20);
            label2.Name = "label2";
            label2.Size = new Size(78, 27);
            label2.TabIndex = 38;
            label2.Text = "DICA: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("TASTY DONUTS", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Peru;
            label3.Location = new Point(544, 20);
            label3.Name = "label3";
            label3.Size = new Size(100, 27);
            label3.TabIndex = 39;
            label3.Text = "FRUTAS";
            // 
            // lblPalavra
            // 
            lblPalavra.AutoSize = true;
            lblPalavra.Font = new Font("Candara", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPalavra.ForeColor = Color.Peru;
            lblPalavra.Location = new Point(208, 162);
            lblPalavra.Name = "lblPalavra";
            lblPalavra.Size = new Size(0, 42);
            lblPalavra.TabIndex = 41;
            // 
            // pnlBotoes
            // 
            pnlBotoes.Controls.Add(btnCedilha);
            pnlBotoes.Controls.Add(btnA);
            pnlBotoes.Controls.Add(btnB);
            pnlBotoes.Controls.Add(btnC);
            pnlBotoes.Controls.Add(btnD);
            pnlBotoes.Controls.Add(btnE);
            pnlBotoes.Controls.Add(btnZ);
            pnlBotoes.Controls.Add(btnF);
            pnlBotoes.Controls.Add(btnY);
            pnlBotoes.Controls.Add(btnG);
            pnlBotoes.Controls.Add(btnX);
            pnlBotoes.Controls.Add(btnH);
            pnlBotoes.Controls.Add(btnW);
            pnlBotoes.Controls.Add(btnI);
            pnlBotoes.Controls.Add(btnV);
            pnlBotoes.Controls.Add(btnJ);
            pnlBotoes.Controls.Add(btnU);
            pnlBotoes.Controls.Add(btnK);
            pnlBotoes.Controls.Add(btnT);
            pnlBotoes.Controls.Add(btnL);
            pnlBotoes.Controls.Add(btnS);
            pnlBotoes.Controls.Add(btnM);
            pnlBotoes.Controls.Add(btnR);
            pnlBotoes.Controls.Add(btnN);
            pnlBotoes.Controls.Add(btnQ);
            pnlBotoes.Controls.Add(btnO);
            pnlBotoes.Controls.Add(btnP);
            pnlBotoes.Location = new Point(208, 210);
            pnlBotoes.Name = "pnlBotoes";
            pnlBotoes.Size = new Size(454, 125);
            pnlBotoes.TabIndex = 42;
            // 
            // lblDica
            // 
            lblDica.AutoSize = true;
            lblDica.Font = new Font("Candara", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDica.Location = new Point(208, 144);
            lblDica.Name = "lblDica";
            lblDica.Size = new Size(0, 18);
            lblDica.TabIndex = 43;
            // 
            // statusMensagem
            // 
            statusMensagem.Items.AddRange(new ToolStripItem[] { lblMensagemFinal });
            statusMensagem.Location = new Point(0, 349);
            statusMensagem.Name = "statusMensagem";
            statusMensagem.Size = new Size(674, 22);
            statusMensagem.TabIndex = 44;
            statusMensagem.Text = "statusStrip1";
            // 
            // lblMensagemFinal
            // 
            lblMensagemFinal.Name = "lblMensagemFinal";
            lblMensagemFinal.Size = new Size(0, 17);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(674, 371);
            Controls.Add(statusMensagem);
            Controls.Add(lblDica);
            Controls.Add(pnlBotoes);
            Controls.Add(lblPalavra);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnNovoJogo);
            Controls.Add(label1);
            Controls.Add(imgPernaE);
            Controls.Add(imgPernaD);
            Controls.Add(imgBracoE);
            Controls.Add(imgBracoD);
            Controls.Add(imgCorpo);
            Controls.Add(imgCabeca);
            Controls.Add(imgForca);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)imgForca).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCabeca).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCorpo).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgBracoD).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgBracoE).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgPernaD).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgPernaE).EndInit();
            pnlBotoes.ResumeLayout(false);
            statusMensagem.ResumeLayout(false);
            statusMensagem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Button btnE;
        private Button btnF;
        private Button btnG;
        private Button btnH;
        private Button btnI;
        private Button btnJ;
        private Button btnK;
        private Button btnS;
        private Button btnR;
        private Button btnQ;
        private Button btnP;
        private Button btnO;
        private Button btnN;
        private Button btnM;
        private Button btnL;
        private Button btnT;
        private Button btnCedilha;
        private Button btnZ;
        private Button btnY;
        private Button btnX;
        private Button btnW;
        private Button btnV;
        private Button btnU;
        private Button btnNovoJogo;
        private Label label2;
        private Label label3;
        private Label lblPalavra;
        public PictureBox imgCabeca;
        public PictureBox imgCorpo;
        public PictureBox imgBracoD;
        public PictureBox imgBracoE;
        public PictureBox imgPernaD;
        public PictureBox imgPernaE;
        public PictureBox imgForca;
        private Panel pnlBotoes;
        private Label lblDica;
        private StatusStrip statusMensagem;
        private ToolStripStatusLabel lblMensagemFinal;
    }
}