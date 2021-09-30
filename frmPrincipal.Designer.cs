namespace CG
{
    partial class frmPrincipal
    {
        private System.ComponentModel.IContainer components = null;



        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btAbrirImagem = new System.Windows.Forms.Button();
            this.btRestaurar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.btSaturacaoMais = new System.Windows.Forms.Button();
            this.btLumMais = new System.Windows.Forms.Button();
            this.btMatizMais = new System.Windows.Forms.Button();
            this.btSaturacaoMenos = new System.Windows.Forms.Button();
            this.btLumMenos = new System.Windows.Forms.Button();
            this.btMatizMenos = new System.Windows.Forms.Button();
            this.lSaturacao = new System.Windows.Forms.Label();
            this.lLuminancia = new System.Windows.Forms.Label();
            this.lMatiz = new System.Windows.Forms.Label();
            this.lS = new System.Windows.Forms.Label();
            this.lL = new System.Windows.Forms.Label();
            this.lH = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lMagenta = new System.Windows.Forms.Label();
            this.lCyano = new System.Windows.Forms.Label();
            this.lYellow = new System.Windows.Forms.Label();
            this.lGreen = new System.Windows.Forms.Label();
            this.lBlue = new System.Windows.Forms.Label();
            this.lRed = new System.Windows.Forms.Label();
            this.lY = new System.Windows.Forms.Label();
            this.lX = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lVarI = new System.Windows.Forms.Label();
            this.lVarS = new System.Windows.Forms.Label();
            this.lVarH = new System.Windows.Forms.Label();
            this.pbH = new System.Windows.Forms.PictureBox();
            this.gbH = new System.Windows.Forms.GroupBox();
            this.gbS = new System.Windows.Forms.GroupBox();
            this.pbS = new System.Windows.Forms.PictureBox();
            this.gbI = new System.Windows.Forms.GroupBox();
            this.pbI = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbH)).BeginInit();
            this.gbH.SuspendLayout();
            this.gbS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbS)).BeginInit();
            this.gbI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbI)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(608, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // btAbrirImagem
            // 
            this.btAbrirImagem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btAbrirImagem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAbrirImagem.FlatAppearance.BorderSize = 0;
            this.btAbrirImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAbrirImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbrirImagem.ForeColor = System.Drawing.Color.White;
            this.btAbrirImagem.Location = new System.Drawing.Point(12, 471);
            this.btAbrirImagem.Name = "btAbrirImagem";
            this.btAbrirImagem.Size = new System.Drawing.Size(132, 34);
            this.btAbrirImagem.TabIndex = 1;
            this.btAbrirImagem.Text = "Abrir Imagem";
            this.btAbrirImagem.UseVisualStyleBackColor = false;
            this.btAbrirImagem.Click += new System.EventHandler(this.btAbrirImagem_Click);
            // 
            // btRestaurar
            // 
            this.btRestaurar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btRestaurar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btRestaurar.FlatAppearance.BorderSize = 0;
            this.btRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRestaurar.ForeColor = System.Drawing.Color.White;
            this.btRestaurar.Location = new System.Drawing.Point(150, 471);
            this.btRestaurar.Name = "btRestaurar";
            this.btRestaurar.Size = new System.Drawing.Size(98, 34);
            this.btRestaurar.TabIndex = 3;
            this.btRestaurar.Text = "Restaurar";
            this.btRestaurar.UseVisualStyleBackColor = false;
            this.btRestaurar.Click += new System.EventHandler(this.btRestaurar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btLimpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btLimpar.FlatAppearance.BorderSize = 0;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.Color.White;
            this.btLimpar.Location = new System.Drawing.Point(543, 471);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(77, 34);
            this.btLimpar.TabIndex = 4;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.lVarH);
            this.gbFiltros.Controls.Add(this.lVarS);
            this.gbFiltros.Controls.Add(this.lVarI);
            this.gbFiltros.Controls.Add(this.btSaturacaoMais);
            this.gbFiltros.Controls.Add(this.btLumMais);
            this.gbFiltros.Controls.Add(this.btMatizMais);
            this.gbFiltros.Controls.Add(this.btSaturacaoMenos);
            this.gbFiltros.Controls.Add(this.btLumMenos);
            this.gbFiltros.Controls.Add(this.btMatizMenos);
            this.gbFiltros.Controls.Add(this.lSaturacao);
            this.gbFiltros.Controls.Add(this.lLuminancia);
            this.gbFiltros.Controls.Add(this.lMatiz);
            this.gbFiltros.Controls.Add(this.lS);
            this.gbFiltros.Controls.Add(this.lL);
            this.gbFiltros.Controls.Add(this.lH);
            this.gbFiltros.Location = new System.Drawing.Point(13, 512);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(607, 115);
            this.gbFiltros.TabIndex = 5;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "´Filtros";
            // 
            // btSaturacaoMais
            // 
            this.btSaturacaoMais.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btSaturacaoMais.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btSaturacaoMais.FlatAppearance.BorderSize = 0;
            this.btSaturacaoMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSaturacaoMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaturacaoMais.ForeColor = System.Drawing.Color.White;
            this.btSaturacaoMais.Location = new System.Drawing.Point(257, 46);
            this.btSaturacaoMais.Name = "btSaturacaoMais";
            this.btSaturacaoMais.Size = new System.Drawing.Size(35, 26);
            this.btSaturacaoMais.TabIndex = 11;
            this.btSaturacaoMais.Text = "+5";
            this.btSaturacaoMais.UseVisualStyleBackColor = false;
            this.btSaturacaoMais.Click += new System.EventHandler(this.btSaturacaoMais_Click);
            // 
            // btLumMais
            // 
            this.btLumMais.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btLumMais.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btLumMais.FlatAppearance.BorderSize = 0;
            this.btLumMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLumMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLumMais.ForeColor = System.Drawing.Color.White;
            this.btLumMais.Location = new System.Drawing.Point(257, 78);
            this.btLumMais.Name = "btLumMais";
            this.btLumMais.Size = new System.Drawing.Size(35, 26);
            this.btLumMais.TabIndex = 10;
            this.btLumMais.Text = "+5";
            this.btLumMais.UseVisualStyleBackColor = false;
            this.btLumMais.Click += new System.EventHandler(this.btLumMais_Click);
            // 
            // btMatizMais
            // 
            this.btMatizMais.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btMatizMais.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btMatizMais.FlatAppearance.BorderSize = 0;
            this.btMatizMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMatizMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMatizMais.ForeColor = System.Drawing.Color.White;
            this.btMatizMais.Location = new System.Drawing.Point(257, 14);
            this.btMatizMais.Name = "btMatizMais";
            this.btMatizMais.Size = new System.Drawing.Size(35, 26);
            this.btMatizMais.TabIndex = 9;
            this.btMatizMais.Text = "+5";
            this.btMatizMais.UseVisualStyleBackColor = false;
            this.btMatizMais.Click += new System.EventHandler(this.btMatizMais_Click);
            // 
            // btSaturacaoMenos
            // 
            this.btSaturacaoMenos.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btSaturacaoMenos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btSaturacaoMenos.FlatAppearance.BorderSize = 0;
            this.btSaturacaoMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSaturacaoMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaturacaoMenos.ForeColor = System.Drawing.Color.White;
            this.btSaturacaoMenos.Location = new System.Drawing.Point(216, 46);
            this.btSaturacaoMenos.Name = "btSaturacaoMenos";
            this.btSaturacaoMenos.Size = new System.Drawing.Size(35, 26);
            this.btSaturacaoMenos.TabIndex = 8;
            this.btSaturacaoMenos.Text = "-5";
            this.btSaturacaoMenos.UseVisualStyleBackColor = false;
            this.btSaturacaoMenos.Click += new System.EventHandler(this.btSaturacaoMenos_Click);
            // 
            // btLumMenos
            // 
            this.btLumMenos.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btLumMenos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btLumMenos.FlatAppearance.BorderSize = 0;
            this.btLumMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLumMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLumMenos.ForeColor = System.Drawing.Color.White;
            this.btLumMenos.Location = new System.Drawing.Point(216, 78);
            this.btLumMenos.Name = "btLumMenos";
            this.btLumMenos.Size = new System.Drawing.Size(35, 26);
            this.btLumMenos.TabIndex = 7;
            this.btLumMenos.Text = "-5";
            this.btLumMenos.UseVisualStyleBackColor = false;
            this.btLumMenos.Click += new System.EventHandler(this.btLumMenos_Click);
            // 
            // btMatizMenos
            // 
            this.btMatizMenos.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btMatizMenos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btMatizMenos.FlatAppearance.BorderSize = 0;
            this.btMatizMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMatizMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMatizMenos.ForeColor = System.Drawing.Color.White;
            this.btMatizMenos.Location = new System.Drawing.Point(216, 14);
            this.btMatizMenos.Name = "btMatizMenos";
            this.btMatizMenos.Size = new System.Drawing.Size(35, 26);
            this.btMatizMenos.TabIndex = 6;
            this.btMatizMenos.Text = "-5";
            this.btMatizMenos.UseVisualStyleBackColor = false;
            this.btMatizMenos.Click += new System.EventHandler(this.btMatizMenos_Click);
            // 
            // lSaturacao
            // 
            this.lSaturacao.AutoSize = true;
            this.lSaturacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSaturacao.Location = new System.Drawing.Point(102, 49);
            this.lSaturacao.Name = "lSaturacao";
            this.lSaturacao.Size = new System.Drawing.Size(108, 20);
            this.lSaturacao.TabIndex = 5;
            this.lSaturacao.Text = "Saturação (S)";
            // 
            // lLuminancia
            // 
            this.lLuminancia.AutoSize = true;
            this.lLuminancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLuminancia.Location = new System.Drawing.Point(102, 81);
            this.lLuminancia.Name = "lLuminancia";
            this.lLuminancia.Size = new System.Drawing.Size(109, 20);
            this.lLuminancia.TabIndex = 4;
            this.lLuminancia.Text = "Luminância (I)";
            // 
            // lMatiz
            // 
            this.lMatiz.AutoSize = true;
            this.lMatiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMatiz.Location = new System.Drawing.Point(102, 17);
            this.lMatiz.Name = "lMatiz";
            this.lMatiz.Size = new System.Drawing.Size(73, 20);
            this.lMatiz.TabIndex = 3;
            this.lMatiz.Text = "Matiz (H)";
            // 
            // lS
            // 
            this.lS.AutoSize = true;
            this.lS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lS.Location = new System.Drawing.Point(7, 49);
            this.lS.Name = "lS";
            this.lS.Size = new System.Drawing.Size(18, 20);
            this.lS.TabIndex = 2;
            this.lS.Text = "0";
            // 
            // lL
            // 
            this.lL.AutoSize = true;
            this.lL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lL.Location = new System.Drawing.Point(7, 81);
            this.lL.Name = "lL";
            this.lL.Size = new System.Drawing.Size(18, 20);
            this.lL.TabIndex = 1;
            this.lL.Text = "0";
            // 
            // lH
            // 
            this.lH.AutoSize = true;
            this.lH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lH.Location = new System.Drawing.Point(7, 17);
            this.lH.Name = "lH";
            this.lH.Size = new System.Drawing.Size(18, 20);
            this.lH.TabIndex = 0;
            this.lH.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Controls.Add(this.lMagenta);
            this.groupBox1.Controls.Add(this.lCyano);
            this.groupBox1.Controls.Add(this.lYellow);
            this.groupBox1.Controls.Add(this.lGreen);
            this.groupBox1.Controls.Add(this.lBlue);
            this.groupBox1.Controls.Add(this.lRed);
            this.groupBox1.Controls.Add(this.lY);
            this.groupBox1.Controls.Add(this.lX);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(651, 471);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 172);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cor do pixel";
            // 
            // lMagenta
            // 
            this.lMagenta.AutoSize = true;
            this.lMagenta.BackColor = System.Drawing.Color.Transparent;
            this.lMagenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMagenta.ForeColor = System.Drawing.Color.Magenta;
            this.lMagenta.Location = new System.Drawing.Point(10, 130);
            this.lMagenta.Name = "lMagenta";
            this.lMagenta.Size = new System.Drawing.Size(24, 16);
            this.lMagenta.TabIndex = 7;
            this.lMagenta.Text = "M:";
            // 
            // lCyano
            // 
            this.lCyano.AutoSize = true;
            this.lCyano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCyano.ForeColor = System.Drawing.Color.Cyan;
            this.lCyano.Location = new System.Drawing.Point(10, 114);
            this.lCyano.Name = "lCyano";
            this.lCyano.Size = new System.Drawing.Size(22, 16);
            this.lCyano.TabIndex = 6;
            this.lCyano.Text = "C:";
            // 
            // lYellow
            // 
            this.lYellow.AutoSize = true;
            this.lYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lYellow.ForeColor = System.Drawing.Color.Yellow;
            this.lYellow.Location = new System.Drawing.Point(10, 146);
            this.lYellow.Name = "lYellow";
            this.lYellow.Size = new System.Drawing.Size(22, 16);
            this.lYellow.TabIndex = 5;
            this.lYellow.Text = "Y:";
            // 
            // lGreen
            // 
            this.lGreen.AutoSize = true;
            this.lGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGreen.ForeColor = System.Drawing.Color.Lime;
            this.lGreen.Location = new System.Drawing.Point(10, 74);
            this.lGreen.Name = "lGreen";
            this.lGreen.Size = new System.Drawing.Size(23, 16);
            this.lGreen.TabIndex = 4;
            this.lGreen.Text = "G:";
            // 
            // lBlue
            // 
            this.lBlue.AutoSize = true;
            this.lBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBlue.ForeColor = System.Drawing.Color.Blue;
            this.lBlue.Location = new System.Drawing.Point(10, 90);
            this.lBlue.Name = "lBlue";
            this.lBlue.Size = new System.Drawing.Size(22, 16);
            this.lBlue.TabIndex = 3;
            this.lBlue.Text = "B:";
            // 
            // lRed
            // 
            this.lRed.AutoSize = true;
            this.lRed.BackColor = System.Drawing.Color.Transparent;
            this.lRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRed.ForeColor = System.Drawing.Color.Red;
            this.lRed.Location = new System.Drawing.Point(10, 58);
            this.lRed.Name = "lRed";
            this.lRed.Size = new System.Drawing.Size(23, 16);
            this.lRed.TabIndex = 2;
            this.lRed.Text = "R:";
            // 
            // lY
            // 
            this.lY.AutoSize = true;
            this.lY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lY.Location = new System.Drawing.Point(10, 36);
            this.lY.Name = "lY";
            this.lY.Size = new System.Drawing.Size(24, 16);
            this.lY.TabIndex = 1;
            this.lY.Text = "Y=";
            // 
            // lX
            // 
            this.lX.AutoSize = true;
            this.lX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lX.Location = new System.Drawing.Point(10, 20);
            this.lX.Name = "lX";
            this.lX.Size = new System.Drawing.Size(23, 16);
            this.lX.TabIndex = 0;
            this.lX.Text = "X=";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lVarI
            // 
            this.lVarI.AutoSize = true;
            this.lVarI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVarI.Location = new System.Drawing.Point(49, 81);
            this.lVarI.Name = "lVarI";
            this.lVarI.Size = new System.Drawing.Size(27, 20);
            this.lVarI.TabIndex = 12;
            this.lVarI.Text = "+0";
            // 
            // lVarS
            // 
            this.lVarS.AutoSize = true;
            this.lVarS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVarS.Location = new System.Drawing.Point(49, 49);
            this.lVarS.Name = "lVarS";
            this.lVarS.Size = new System.Drawing.Size(27, 20);
            this.lVarS.TabIndex = 13;
            this.lVarS.Text = "+0";
            // 
            // lVarH
            // 
            this.lVarH.AutoSize = true;
            this.lVarH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVarH.Location = new System.Drawing.Point(49, 17);
            this.lVarH.Name = "lVarH";
            this.lVarH.Size = new System.Drawing.Size(27, 20);
            this.lVarH.TabIndex = 14;
            this.lVarH.Text = "+0";
            // 
            // pbH
            // 
            this.pbH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbH.Location = new System.Drawing.Point(6, 19);
            this.pbH.Name = "pbH";
            this.pbH.Size = new System.Drawing.Size(188, 124);
            this.pbH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbH.TabIndex = 7;
            this.pbH.TabStop = false;
            this.pbH.Tag = "";
            // 
            // gbH
            // 
            this.gbH.Controls.Add(this.pbH);
            this.gbH.Location = new System.Drawing.Point(626, 7);
            this.gbH.Name = "gbH";
            this.gbH.Size = new System.Drawing.Size(200, 149);
            this.gbH.TabIndex = 8;
            this.gbH.TabStop = false;
            this.gbH.Text = "H";
            // 
            // gbS
            // 
            this.gbS.Controls.Add(this.pbS);
            this.gbS.Location = new System.Drawing.Point(626, 162);
            this.gbS.Name = "gbS";
            this.gbS.Size = new System.Drawing.Size(200, 149);
            this.gbS.TabIndex = 9;
            this.gbS.TabStop = false;
            this.gbS.Text = "S";
            // 
            // pbS
            // 
            this.pbS.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbS.Location = new System.Drawing.Point(6, 19);
            this.pbS.Name = "pbS";
            this.pbS.Size = new System.Drawing.Size(188, 124);
            this.pbS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbS.TabIndex = 7;
            this.pbS.TabStop = false;
            this.pbS.Tag = "";
            // 
            // gbI
            // 
            this.gbI.Controls.Add(this.pbI);
            this.gbI.Location = new System.Drawing.Point(626, 317);
            this.gbI.Name = "gbI";
            this.gbI.Size = new System.Drawing.Size(200, 149);
            this.gbI.TabIndex = 9;
            this.gbI.TabStop = false;
            this.gbI.Text = "I";
            // 
            // pbI
            // 
            this.pbI.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbI.Location = new System.Drawing.Point(6, 19);
            this.pbI.Name = "pbI";
            this.pbI.Size = new System.Drawing.Size(188, 124);
            this.pbI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbI.TabIndex = 7;
            this.pbI.TabStop = false;
            this.pbI.Tag = "";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(833, 648);
            this.Controls.Add(this.gbI);
            this.Controls.Add(this.gbS);
            this.Controls.Add(this.gbH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.btAbrirImagem);
            this.Controls.Add(this.btRestaurar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPrincipal";
            this.Text = "CG";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbH)).EndInit();
            this.gbH.ResumeLayout(false);
            this.gbS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbS)).EndInit();
            this.gbI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btAbrirImagem;
        private System.Windows.Forms.Button btRestaurar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Label lS;
        private System.Windows.Forms.Label lL;
        private System.Windows.Forms.Label lH;
        private System.Windows.Forms.Button btSaturacaoMais;
        private System.Windows.Forms.Button btLumMais;
        private System.Windows.Forms.Button btMatizMais;
        private System.Windows.Forms.Button btSaturacaoMenos;
        private System.Windows.Forms.Button btLumMenos;
        private System.Windows.Forms.Button btMatizMenos;
        private System.Windows.Forms.Label lSaturacao;
        private System.Windows.Forms.Label lLuminancia;
        private System.Windows.Forms.Label lMatiz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lMagenta;
        private System.Windows.Forms.Label lCyano;
        private System.Windows.Forms.Label lYellow;
        private System.Windows.Forms.Label lGreen;
        private System.Windows.Forms.Label lBlue;
        private System.Windows.Forms.Label lRed;
        private System.Windows.Forms.Label lY;
        private System.Windows.Forms.Label lX;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lVarH;
        private System.Windows.Forms.Label lVarS;
        private System.Windows.Forms.Label lVarI;
        private System.Windows.Forms.PictureBox pbH;
        private System.Windows.Forms.GroupBox gbH;
        private System.Windows.Forms.GroupBox gbS;
        private System.Windows.Forms.PictureBox pbS;
        private System.Windows.Forms.GroupBox gbI;
        private System.Windows.Forms.PictureBox pbI;
    }
}

