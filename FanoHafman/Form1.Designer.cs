namespace FanoHafman
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.fanoRadioButton = new System.Windows.Forms.RadioButton();
            this.haffmanRadioButton = new System.Windows.Forms.RadioButton();
            this.alphabetGridView = new System.Windows.Forms.DataGridView();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.fanoGridView = new System.Windows.Forms.DataGridView();
            this.Ngr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Np = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.fanoResultGridView = new System.Windows.Forms.DataGridView();
            this.SymbolFano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeFano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haffmanResultGridView = new System.Windows.Forms.DataGridView();
            this.haffmanGridView = new System.Windows.Forms.DataGridView();
            this.SymbolHafman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haffmanCodeResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.alphabetGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fanoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fanoResultGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.haffmanResultGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.haffmanGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fanoRadioButton
            // 
            this.fanoRadioButton.AutoSize = true;
            this.fanoRadioButton.Checked = true;
            this.fanoRadioButton.Location = new System.Drawing.Point(3, 3);
            this.fanoRadioButton.Name = "fanoRadioButton";
            this.fanoRadioButton.Size = new System.Drawing.Size(106, 17);
            this.fanoRadioButton.TabIndex = 0;
            this.fanoRadioButton.TabStop = true;
            this.fanoRadioButton.Text = "Алгоритм Фано";
            this.fanoRadioButton.UseVisualStyleBackColor = true;
            // 
            // haffmanRadioButton
            // 
            this.haffmanRadioButton.AutoSize = true;
            this.haffmanRadioButton.Location = new System.Drawing.Point(3, 26);
            this.haffmanRadioButton.Name = "haffmanRadioButton";
            this.haffmanRadioButton.Size = new System.Drawing.Size(132, 17);
            this.haffmanRadioButton.TabIndex = 1;
            this.haffmanRadioButton.Text = "Алгоритм Хаффмана";
            this.haffmanRadioButton.UseVisualStyleBackColor = true;
            // 
            // alphabetGridView
            // 
            this.alphabetGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alphabetGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Symbol,
            this.Fequency});
            this.alphabetGridView.Location = new System.Drawing.Point(12, 70);
            this.alphabetGridView.Name = "alphabetGridView";
            this.alphabetGridView.RowHeadersVisible = false;
            this.alphabetGridView.Size = new System.Drawing.Size(143, 188);
            this.alphabetGridView.TabIndex = 2;
            // 
            // Symbol
            // 
            this.Symbol.HeaderText = "Символ";
            this.Symbol.Name = "Symbol";
            this.Symbol.Width = 68;
            // 
            // Fequency
            // 
            this.Fequency.HeaderText = "Частота";
            this.Fequency.Name = "Fequency";
            this.Fequency.Width = 68;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.fanoRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.haffmanRadioButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(141, 52);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // fanoGridView
            // 
            this.fanoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fanoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ngr,
            this.Np,
            this.Nk,
            this.S,
            this.L,
            this.Code});
            this.fanoGridView.Location = new System.Drawing.Point(176, 12);
            this.fanoGridView.Name = "fanoGridView";
            this.fanoGridView.RowHeadersVisible = false;
            this.fanoGridView.Size = new System.Drawing.Size(285, 326);
            this.fanoGridView.TabIndex = 4;
            // 
            // Ngr
            // 
            this.Ngr.HeaderText = "Nгрупи";
            this.Ngr.Name = "Ngr";
            this.Ngr.Width = 50;
            // 
            // Np
            // 
            this.Np.HeaderText = "Np";
            this.Np.Name = "Np";
            this.Np.Width = 40;
            // 
            // Nk
            // 
            this.Nk.HeaderText = "Nk";
            this.Nk.Name = "Nk";
            this.Nk.Width = 40;
            // 
            // S
            // 
            this.S.HeaderText = "S";
            this.S.Name = "S";
            this.S.Width = 40;
            // 
            // L
            // 
            this.L.HeaderText = "L";
            this.L.Name = "L";
            this.L.Width = 40;
            // 
            // Code
            // 
            this.Code.HeaderText = "Код";
            this.Code.Name = "Code";
            this.Code.Width = 70;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(12, 306);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(143, 32);
            this.button.TabIndex = 5;
            this.button.Text = "Виконати";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(33, 274);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(42, 13);
            this.label.TabIndex = 6;
            this.label.Text = "Сума =";
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(98, 274);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(0, 13);
            this.sumLabel.TabIndex = 7;
            // 
            // fanoResultGridView
            // 
            this.fanoResultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fanoResultGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SymbolFano,
            this.CodeFano});
            this.fanoResultGridView.Location = new System.Drawing.Point(467, 12);
            this.fanoResultGridView.Name = "fanoResultGridView";
            this.fanoResultGridView.RowHeadersVisible = false;
            this.fanoResultGridView.Size = new System.Drawing.Size(132, 200);
            this.fanoResultGridView.TabIndex = 8;
            // 
            // SymbolFano
            // 
            this.SymbolFano.HeaderText = "Cимвол";
            this.SymbolFano.Name = "SymbolFano";
            this.SymbolFano.Width = 63;
            // 
            // CodeFano
            // 
            this.CodeFano.HeaderText = "Код (Фано)";
            this.CodeFano.Name = "CodeFano";
            this.CodeFano.Width = 63;
            // 
            // haffmanResultGridView
            // 
            this.haffmanResultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.haffmanResultGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SymbolHafman,
            this.haffmanCodeResult});
            this.haffmanResultGridView.Location = new System.Drawing.Point(907, 12);
            this.haffmanResultGridView.Name = "haffmanResultGridView";
            this.haffmanResultGridView.RowHeadersVisible = false;
            this.haffmanResultGridView.Size = new System.Drawing.Size(133, 200);
            this.haffmanResultGridView.TabIndex = 9;
            // 
            // haffmanGridView
            // 
            this.haffmanGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.haffmanGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.haffmanGridView.Location = new System.Drawing.Point(616, 12);
            this.haffmanGridView.Name = "haffmanGridView";
            this.haffmanGridView.RowHeadersVisible = false;
            this.haffmanGridView.Size = new System.Drawing.Size(285, 326);
            this.haffmanGridView.TabIndex = 10;
            // 
            // SymbolHafman
            // 
            this.SymbolHafman.HeaderText = "Символ";
            this.SymbolHafman.Name = "SymbolHafman";
            this.SymbolHafman.Width = 63;
            // 
            // haffmanCodeResult
            // 
            this.haffmanCodeResult.HeaderText = "Код (Хаффман)";
            this.haffmanCodeResult.Name = "haffmanCodeResult";
            this.haffmanCodeResult.Width = 64;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "N";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "JM1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 40;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "JM2";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 40;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "JMS";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 40;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "JML";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 40;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "ZMK";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 54;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 366);
            this.Controls.Add(this.haffmanGridView);
            this.Controls.Add(this.haffmanResultGridView);
            this.Controls.Add(this.fanoResultGridView);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button);
            this.Controls.Add(this.fanoGridView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.alphabetGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.alphabetGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fanoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fanoResultGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.haffmanResultGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.haffmanGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton fanoRadioButton;
        private System.Windows.Forms.RadioButton haffmanRadioButton;
        private System.Windows.Forms.DataGridView alphabetGridView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView fanoGridView;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Np;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nk;
        private System.Windows.Forms.DataGridViewTextBoxColumn S;
        private System.Windows.Forms.DataGridViewTextBoxColumn L;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.DataGridView fanoResultGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SymbolFano;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeFano;
        private System.Windows.Forms.DataGridView haffmanResultGridView;
        private System.Windows.Forms.DataGridView haffmanGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn SymbolHafman;
        private System.Windows.Forms.DataGridViewTextBoxColumn haffmanCodeResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

