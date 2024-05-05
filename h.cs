using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MyBIOS.Properties;

public class h : Form
{
	private m m_a;

	private u m_b;

	private s m_c;

	private bool m_d;

	private IContainer m_e;

	private ListView m_f;

	private ColumnHeader g;

	private ColumnHeader m_h;

	private Button i;

	private Button j;

	private PictureBox k;

	private PictureBox l;

	private Label m;

	private Label n;

	private Label o;

	public h(s A_0)
	{
		this.m_c = A_0;
		a();
		this.m_b = new u(A_0: true, this.m_c, this);
		this.m_a = new m(this.m_b);
		this.m_b.i = this.m_a;
		this.m_f.Items.Clear();
		this.m_f.Items.Add("Main");
		this.m_f.Items[0].SubItems.Add(this.m_a.s[0]);
		this.m_f.Items.Add("Main");
		this.m_f.Items[1].SubItems.Add(this.m_a.t[0]);
		this.m_f.Items.Add("Main");
		this.m_f.Items[2].SubItems.Add(this.m_a.u[0]);
		this.m_f.Items.Add("Advanced");
		this.m_f.Items[3].SubItems.Add(this.m_a.v[0]);
		this.m_f.Items.Add("Advanced");
		this.m_f.Items[4].SubItems.Add(this.m_a.w[0]);
		this.m_f.Items.Add("Advanced");
		this.m_f.Items[5].SubItems.Add(this.m_a.x[0]);
		this.m_f.Items.Add("Advanced");
		this.m_f.Items[6].SubItems.Add(this.m_a.y[0]);
		this.m_f.Items.Add("Power");
		this.m_f.Items[7].SubItems.Add(this.m_a.z[0]);
		this.m_f.Items.Add("Power");
		this.m_f.Items[8].SubItems.Add(this.m_a.aa[0]);
		this.m_f.Items.Add("Boot");
		this.m_f.Items[9].SubItems.Add(this.m_a.ab[0]);
		this.m_f.Items[0].Selected = true;
	}

	private void f(object A_0, EventArgs A_1)
	{
		Hide();
		if (!this.m_d)
		{
			j.Visible = false;
			l.Visible = false;
			k.Visible = false;
			base.MinimizeBox = false;
			i.Location = new Point(345, 516);
			this.m_b.a.Show();
			this.m_d = true;
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		if (!this.m_d)
		{
			this.m_c.Show();
		}
		else
		{
			Hide();
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		k.Image = Resources.Forward;
	}

	private void c(object A_0, EventArgs A_1)
	{
		k.Image = Resources.Forward_d;
	}

	private void b(object A_0, EventArgs A_1)
	{
		l.Image = Resources.Back;
	}

	private void a(object A_0, EventArgs A_1)
	{
		l.Image = Resources.Back_d;
	}

	private void a(object A_0, ListViewItemSelectionChangedEventArgs A_1)
	{
		int itemIndex = A_1.ItemIndex;
		o.Text = "Задание из раздела " + this.m_f.Items[itemIndex].Text + ":";
		n.Text = this.m_f.Items[itemIndex].SubItems[1].Text;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.m_e != null)
		{
			this.m_e.Dispose();
		}
		base.Dispose(disposing);
	}

	private void a()
	{
		this.m_f = new ListView();
		g = new ColumnHeader();
		m_h = new ColumnHeader();
		i = new Button();
		j = new Button();
		k = new PictureBox();
		l = new PictureBox();
		m = new Label();
		n = new Label();
		o = new Label();
		((ISupportInitialize)k).BeginInit();
		((ISupportInitialize)l).BeginInit();
		SuspendLayout();
		this.m_f.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		this.m_f.BackColor = Color.White;
		this.m_f.Columns.AddRange(new ColumnHeader[2] { g, m_h });
		this.m_f.Font = new Font("Verdana", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		this.m_f.ForeColor = Color.Black;
		this.m_f.FullRowSelect = true;
		this.m_f.Location = new Point(12, 70);
		this.m_f.MultiSelect = false;
		this.m_f.Name = "Zadaniya_list";
		this.m_f.ShowGroups = false;
		this.m_f.ShowItemToolTips = true;
		this.m_f.Size = new Size(766, 270);
		this.m_f.TabIndex = 0;
		this.m_f.UseCompatibleStateImageBehavior = false;
		this.m_f.View = View.Details;
		this.m_f.ItemSelectionChanged += a;
		g.Text = "Раздел";
		g.Width = 90;
		m_h.Text = "Задание";
		m_h.Width = 1600;
		i.Font = new Font("Verdana", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		i.ForeColor = Color.Black;
		i.Location = new Point(402, 516);
		i.Name = "Start";
		i.Size = new Size(110, 32);
		i.TabIndex = 1;
		i.Text = "ОК";
		i.UseVisualStyleBackColor = true;
		i.MouseLeave += c;
		i.Click += f;
		i.MouseEnter += d;
		j.Font = new Font("Verdana", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		j.ForeColor = Color.Black;
		j.Location = new Point(246, 516);
		j.Name = "Back";
		j.Size = new Size(110, 32);
		j.TabIndex = 2;
		j.Text = "Назад";
		j.UseVisualStyleBackColor = true;
		j.MouseLeave += a;
		j.Click += e;
		j.MouseEnter += b;
		k.Image = Resources.Forward_d;
		k.Location = new Point(518, 516);
		k.Name = "Forward_pict";
		k.Size = new Size(32, 32);
		k.TabIndex = 24;
		k.TabStop = false;
		l.Image = Resources.Back_d;
		l.Location = new Point(208, 516);
		l.Name = "Back_pict";
		l.Size = new Size(32, 32);
		l.TabIndex = 25;
		l.TabStop = false;
		m.AutoSize = true;
		m.Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
		m.ForeColor = Color.White;
		m.Location = new Point(12, 23);
		m.Name = "Shapka";
		m.Size = new Size(680, 36);
		m.TabIndex = 26;
		m.Text = "Вам необходимо сконфигурировать BIOS Setup Utility в соответствии со всеми \r\nпоставленными заданиями:";
		n.BackColor = Color.DimGray;
		n.Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
		n.ForeColor = Color.White;
		n.Location = new Point(12, 373);
		n.Name = "CurrentZadaniye";
		n.Size = new Size(766, 110);
		n.TabIndex = 27;
		o.BackColor = Color.DimGray;
		o.Font = new Font("Verdana", 12f, FontStyle.Bold, GraphicsUnit.Point, 204);
		o.ForeColor = Color.White;
		o.Location = new Point(12, 350);
		o.Name = "CurrentZadaniyeNum";
		o.Size = new Size(766, 23);
		o.TabIndex = 28;
		base.AutoScaleDimensions = new SizeF(10f, 18f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.DimGray;
		base.ClientSize = new Size(790, 561);
		base.Controls.Add(this.m_f);
		base.Controls.Add(o);
		base.Controls.Add(n);
		base.Controls.Add(m);
		base.Controls.Add(l);
		base.Controls.Add(k);
		base.Controls.Add(j);
		base.Controls.Add(i);
		Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.FormBorderStyle = FormBorderStyle.Fixed3D;
		base.MaximizeBox = false;
		base.Name = "StartTest_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "MyBIOS | Список заданий";
		base.FormClosing += a;
		((ISupportInitialize)k).EndInit();
		((ISupportInitialize)l).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
