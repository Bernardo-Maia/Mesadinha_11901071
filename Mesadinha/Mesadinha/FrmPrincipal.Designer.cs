namespace Mesadinha
{
    partial class FrmPrincipal
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
            this.LblInicio = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.DtgLista = new System.Windows.Forms.DataGridView();
            this.LblTipo = new System.Windows.Forms.Label();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.LblValor = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LblSuaid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgLista)).BeginInit();
            this.SuspendLayout();
            // 
            // LblInicio
            // 
            this.LblInicio.AutoSize = true;
            this.LblInicio.Location = new System.Drawing.Point(3, 12);
            this.LblInicio.Name = "LblInicio";
            this.LblInicio.Size = new System.Drawing.Size(57, 13);
            this.LblInicio.TabIndex = 0;
            this.LblInicio.Text = "Bem vindo";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(6, 153);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(156, 20);
            this.TxtNome.TabIndex = 4;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(3, 137);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(35, 13);
            this.LblNome.TabIndex = 5;
            this.LblNome.Text = "Nome";
            this.LblNome.Click += new System.EventHandler(this.label4_Click);
            // 
            // DtgLista
            // 
            this.DtgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgLista.Location = new System.Drawing.Point(171, 12);
            this.DtgLista.Name = "DtgLista";
            this.DtgLista.Size = new System.Drawing.Size(507, 265);
            this.DtgLista.TabIndex = 6;
            this.DtgLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Location = new System.Drawing.Point(3, 215);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(28, 13);
            this.LblTipo.TabIndex = 8;
            this.LblTipo.Text = "Tipo";
            // 
            // CmbTipo
            // 
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Items.AddRange(new object[] {
            "Gasto",
            "Ganho"});
            this.CmbTipo.Location = new System.Drawing.Point(6, 231);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(156, 21);
            this.CmbTipo.TabIndex = 9;
            this.CmbTipo.Text = "Escolha o tipo";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(6, 254);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = "Adicionar";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(87, 254);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(75, 23);
            this.BtnDel.TabIndex = 11;
            this.BtnDel.Text = "Remover";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Location = new System.Drawing.Point(3, 176);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(31, 13);
            this.LblValor.TabIndex = 13;
            this.LblValor.Text = "Valor";
            // 
            // TxtValor
            // 
            this.TxtValor.AcceptsTab = true;
            this.TxtValor.Location = new System.Drawing.Point(6, 192);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(156, 20);
            this.TxtValor.TabIndex = 12;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(3, 98);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(16, 13);
            this.LblId.TabIndex = 15;
            this.LblId.Text = "Id";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(6, 114);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(156, 20);
            this.TxtId.TabIndex = 14;
            // 
            // LblSuaid
            // 
            this.LblSuaid.AutoSize = true;
            this.LblSuaid.Location = new System.Drawing.Point(3, 51);
            this.LblSuaid.Name = "LblSuaid";
            this.LblSuaid.Size = new System.Drawing.Size(43, 13);
            this.LblSuaid.TabIndex = 16;
            this.LblSuaid.Text = "Sua ID:";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 283);
            this.Controls.Add(this.LblSuaid);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.LblValor);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.CmbTipo);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.DtgLista);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblInicio);
            this.Name = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblInicio;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.DataGridView DtgLista;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label LblSuaid;
    }
}