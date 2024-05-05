using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MyBIOS.Properties;

public class e : Form
{
	private u m_a;

	private ac m_b;

	private int m_c;

	private int m_d = 3;

	private bool m_e = true;

	private IContainer f;

	private PictureBox g;

	private PictureBox h;

	private Panel i;

	private Panel j;

	private PictureBox k;

	private Panel l;

	private Panel m;

	private Panel n;

	private Panel o;

	private Panel p;

	private Panel q;

	private Label r;

	private Label s;

	private Label t;

	private Label u;

	private Label v;

	private Label w;

	private Label x;

	private Label y;

	private Label z;

	private Label aa;

	private Label ab;

	private Label ac;

	public e(u A_0)
	{
		this.m_a = A_0;
		a();
		d();
		c();
	}

	private void d()
	{
		if (this.m_a.ly == "Disabled")
		{
			this.m_a.lv[1] = "(Hard Drive)";
		}
		else
		{
			this.m_a.lv[1] = this.m_a.ly;
		}
		if (this.m_a.lr.IndexOf("HDD:", StringComparison.InvariantCulture) != -1)
		{
			this.m_a.lr = this.m_a.lv[1];
		}
		else if (this.m_a.ls.IndexOf("HDD:", StringComparison.InvariantCulture) != -1)
		{
			this.m_a.ls = this.m_a.lv[1];
		}
		else if (this.m_a.lt.IndexOf("HDD:", StringComparison.InvariantCulture) != -1)
		{
			this.m_a.lt = this.m_a.lv[1];
		}
		else if (this.m_a.lu.IndexOf("HDD:", StringComparison.InvariantCulture) != -1)
		{
			this.m_a.lu = this.m_a.lv[1];
		}
		string[] array = new string[4]
		{
			this.m_a.lr,
			this.m_a.ls,
			this.m_a.lt,
			this.m_a.lu
		};
		int[] array2 = new int[4] { -1, -1, -1, -1 };
		int num = 0;
		for (int num2 = 0; num2 < array.Length; num2++)
		{
			if (array[num2] != "Disabled")
			{
				array2[num] = num2;
				num++;
			}
		}
		switch (num)
		{
		case 0:
			this.m_a.lr = "Disabled";
			this.m_a.ls = "Disabled";
			this.m_a.lt = "Disabled";
			this.m_a.lu = "Disabled";
			y.Visible = false;
			x.Visible = false;
			w.Visible = false;
			v.Visible = false;
			u.Visible = false;
			t.Visible = false;
			this.m_d = 0;
			break;
		case 1:
			this.m_a.lr = array[array2[0]];
			this.m_a.ls = "Disabled";
			this.m_a.lt = "Disabled";
			this.m_a.lu = "Disabled";
			y.Visible = true;
			x.Visible = true;
			w.Visible = false;
			v.Visible = false;
			u.Visible = false;
			t.Visible = false;
			this.m_d = 1;
			break;
		case 2:
			this.m_a.lr = array[array2[0]];
			this.m_a.ls = array[array2[1]];
			this.m_a.lt = "Disabled";
			this.m_a.lu = "Disabled";
			y.Visible = true;
			x.Visible = true;
			w.Visible = true;
			v.Visible = true;
			u.Visible = false;
			t.Visible = false;
			this.m_d = 2;
			break;
		case 3:
			this.m_a.lr = array[array2[0]];
			this.m_a.ls = array[array2[1]];
			this.m_a.lt = array[array2[2]];
			this.m_a.lu = "Disabled";
			y.Visible = true;
			x.Visible = true;
			w.Visible = true;
			v.Visible = true;
			u.Visible = true;
			t.Visible = true;
			this.m_d = 3;
			break;
		case 4:
			this.m_a.lr = array[array2[0]];
			this.m_a.ls = array[array2[1]];
			this.m_a.lt = array[array2[2]];
			this.m_a.lu = array[array2[3]];
			y.Visible = true;
			x.Visible = true;
			w.Visible = true;
			v.Visible = true;
			u.Visible = true;
			t.Visible = true;
			this.m_d = 3;
			break;
		}
		z.Text = this.m_a.k(this.m_a.lr);
		x.Text = this.m_a.k(this.m_a.ls);
		v.Text = this.m_a.k(this.m_a.lt);
		t.Text = this.m_a.k(this.m_a.lu);
		ac.Text = this.m_a.lw;
		ab.Text = this.m_a.o;
	}

	private void c()
	{
		foreach (Control control in i.Controls)
		{
			if (control.Name != "BootDevicePriority_shapka")
			{
				control.ForeColor = this.m_a.g;
			}
		}
		switch (this.m_c)
		{
		case 0:
			aa.ForeColor = Color.White;
			z.ForeColor = Color.White;
			break;
		case 1:
			y.ForeColor = Color.White;
			x.ForeColor = Color.White;
			break;
		case 2:
			w.ForeColor = Color.White;
			v.ForeColor = Color.White;
			break;
		case 3:
			u.ForeColor = Color.White;
			t.ForeColor = Color.White;
			break;
		}
	}

	private void b()
	{
		string a_ = "";
		switch (this.m_c)
		{
		case 0:
			this.m_b = new ac(this.m_a, this.m_a.lr, this.m_a.lv);
			this.m_b.ShowDialog();
			a_ = this.m_a.lr;
			this.m_a.lr = this.m_a.m;
			break;
		case 1:
			this.m_b = new ac(this.m_a, this.m_a.ls, this.m_a.lv);
			this.m_b.ShowDialog();
			a_ = this.m_a.ls;
			this.m_a.ls = this.m_a.m;
			break;
		case 2:
			this.m_b = new ac(this.m_a, this.m_a.lt, this.m_a.lv);
			this.m_b.ShowDialog();
			a_ = this.m_a.lt;
			this.m_a.lt = this.m_a.m;
			break;
		case 3:
			this.m_b = new ac(this.m_a, this.m_a.lu, this.m_a.lv);
			this.m_b.ShowDialog();
			a_ = this.m_a.lu;
			this.m_a.lu = this.m_a.m;
			break;
		}
		a(a_);
		d();
	}

	private void a(bool A_0)
	{
		string[] a_ = new string[4]
		{
			this.m_a.lv[0],
			this.m_a.lv[1],
			this.m_a.lv[2],
			this.m_a.lv[3]
		};
		string a_2 = "";
		switch (this.m_c)
		{
		case 0:
			a_2 = this.m_a.lr;
			this.m_a.k(ref this.m_a.lr, a_, A_0);
			break;
		case 1:
			a_2 = this.m_a.ls;
			this.m_a.k(ref this.m_a.ls, a_, A_0);
			break;
		case 2:
			a_2 = this.m_a.lt;
			this.m_a.k(ref this.m_a.lt, a_, A_0);
			break;
		case 3:
			a_2 = this.m_a.lu;
			this.m_a.k(ref this.m_a.lu, a_, A_0);
			break;
		}
		a(a_2);
		d();
	}

	private void a(string A_0)
	{
		string[] array = new string[4]
		{
			this.m_a.lr,
			this.m_a.ls,
			this.m_a.lt,
			this.m_a.lu
		};
		int num = -1;
		for (int num2 = 0; num2 < array.Length; num2++)
		{
			if (num2 != this.m_c && array[num2] == array[this.m_c] && array[num2] != "Disabled")
			{
				num = num2;
			}
		}
		if (num != -1)
		{
			array[num] = A_0;
			this.m_a.lr = array[0];
			this.m_a.ls = array[1];
			this.m_a.lt = array[2];
			this.m_a.lu = array[3];
		}
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		if (A_1.KeyCode == Keys.Escape)
		{
			m_e = false;
			Close();
		}
		else if (A_1.KeyCode == Keys.Up && this.m_c > 0)
		{
			this.m_c--;
			c();
		}
		else if (A_1.KeyCode == Keys.Down && this.m_c < this.m_d)
		{
			this.m_c++;
			c();
		}
		else if (A_1.KeyCode == Keys.Add)
		{
			a(A_0: true);
		}
		else if (A_1.KeyCode == Keys.Subtract)
		{
			a(A_0: false);
		}
		else if (A_1.KeyCode == Keys.Return)
		{
			b();
		}
		else if (A_1.KeyCode == Keys.Prior || A_1.KeyCode == Keys.Home)
		{
			this.m_c = 0;
			c();
		}
		else if (A_1.KeyCode == Keys.Next || A_1.KeyCode == Keys.End)
		{
			this.m_c = this.m_d;
			c();
		}
		else if (A_1.KeyCode == Keys.F1)
		{
			this.m_a.ng();
		}
		else if (A_1.KeyCode == Keys.F5)
		{
			this.m_a.na();
			d();
		}
		else if (A_1.KeyCode == Keys.F7)
		{
			this.m_a.nd();
			d();
		}
		else if (A_1.KeyCode == Keys.F10)
		{
			this.m_a.l();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		A_1.Cancel = m_e;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && f != null)
		{
			f.Dispose();
		}
		base.Dispose(disposing);
	}

	private void a()
	{
		g = new PictureBox();
		h = new PictureBox();
		i = new Panel();
		t = new Label();
		u = new Label();
		v = new Label();
		w = new Label();
		x = new Label();
		y = new Label();
		z = new Label();
		aa = new Label();
		s = new Label();
		r = new Label();
		q = new Panel();
		j = new Panel();
		ab = new Label();
		ac = new Label();
		k = new PictureBox();
		l = new Panel();
		m = new Panel();
		n = new Panel();
		o = new Panel();
		p = new Panel();
		((ISupportInitialize)g).BeginInit();
		((ISupportInitialize)h).BeginInit();
		i.SuspendLayout();
		j.SuspendLayout();
		((ISupportInitialize)k).BeginInit();
		SuspendLayout();
		g.Dock = DockStyle.Top;
		g.Image = Resources.ShapkaAll;
		g.Location = new Point(0, 0);
		g.Name = "Shapka";
		g.Size = new Size(1280, 35);
		g.SizeMode = PictureBoxSizeMode.StretchImage;
		g.TabIndex = 0;
		g.TabStop = false;
		h.Dock = DockStyle.Top;
		h.Image = Resources.BootOnly;
		h.Location = new Point(0, 35);
		h.Name = "VerhMenu";
		h.Size = new Size(1280, 35);
		h.SizeMode = PictureBoxSizeMode.StretchImage;
		h.TabIndex = 1;
		h.TabStop = false;
		i.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		i.AutoScroll = true;
		i.BackColor = Color.FromArgb(190, 190, 190);
		i.Controls.Add(t);
		i.Controls.Add(u);
		i.Controls.Add(v);
		i.Controls.Add(w);
		i.Controls.Add(x);
		i.Controls.Add(y);
		i.Controls.Add(z);
		i.Controls.Add(aa);
		i.Controls.Add(s);
		i.Controls.Add(r);
		i.Controls.Add(q);
		i.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		i.ForeColor = Color.FromArgb(27, 35, 165);
		i.Location = new Point(12, 92);
		i.Name = "Lev_Panel";
		i.Size = new Size(868, 877);
		i.TabIndex = 2;
		t.Anchor = AnchorStyles.Top;
		t.AutoSize = true;
		t.Location = new Point(386, 188);
		t.Name = "th4BootDevice_Value";
		t.Size = new Size(97, 34);
		t.TabIndex = 54;
		t.Text = "label1";
		u.AutoSize = true;
		u.Location = new Point(22, 188);
		u.Name = "th4BootDevice";
		u.Size = new Size(235, 34);
		u.TabIndex = 53;
		u.Text = "4th Boot Device";
		v.Anchor = AnchorStyles.Top;
		v.AutoSize = true;
		v.Location = new Point(386, 154);
		v.Name = "rd3BootDevice_Value";
		v.Size = new Size(97, 34);
		v.TabIndex = 52;
		v.Text = "label1";
		w.AutoSize = true;
		w.Location = new Point(22, 154);
		w.Name = "rd3BootDevice";
		w.Size = new Size(236, 34);
		w.TabIndex = 51;
		w.Text = "3rd Boot Device";
		x.Anchor = AnchorStyles.Top;
		x.AutoSize = true;
		x.Location = new Point(386, 120);
		x.Name = "nd2BootDevice_Value";
		x.Size = new Size(97, 34);
		x.TabIndex = 50;
		x.Text = "label1";
		y.AutoSize = true;
		y.Location = new Point(22, 120);
		y.Name = "nd2BootDevice";
		y.Size = new Size(243, 34);
		y.TabIndex = 49;
		y.Text = "2nd Boot Device";
		z.Anchor = AnchorStyles.Top;
		z.AutoSize = true;
		z.Location = new Point(386, 86);
		z.Name = "st1BootDevice_Value";
		z.Size = new Size(97, 34);
		z.TabIndex = 48;
		z.Text = "label1";
		aa.AutoSize = true;
		aa.Location = new Point(22, 86);
		aa.Name = "st1BootDevice";
		aa.Size = new Size(233, 34);
		aa.TabIndex = 47;
		aa.Text = "1st Boot Device";
		s.Location = new Point(700, 17);
		s.Name = "End";
		s.Size = new Size(126, 37);
		s.TabIndex = 44;
		r.AutoSize = true;
		r.ForeColor = Color.Black;
		r.Location = new Point(22, 17);
		r.Name = "BootDevicePriority_shapka";
		r.Size = new Size(292, 34);
		r.TabIndex = 35;
		r.Text = "Boot Device Priority";
		q.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		q.BackColor = Color.FromArgb(27, 35, 165);
		q.Location = new Point(18, 68);
		q.Name = "Goriz_1";
		q.Size = new Size(828, 2);
		q.TabIndex = 1;
		j.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		j.AutoScroll = true;
		j.Controls.Add(ab);
		j.Controls.Add(ac);
		j.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		j.ForeColor = Color.FromArgb(27, 35, 165);
		j.Location = new Point(884, 92);
		j.Name = "Prav_Panel";
		j.Size = new Size(382, 877);
		j.TabIndex = 3;
		ab.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		ab.Location = new Point(6, 590);
		ab.Name = "Help_Niz";
		ab.Size = new Size(372, 250);
		ab.TabIndex = 1;
		ac.Location = new Point(6, 15);
		ac.Name = "Help_Verh";
		ac.Size = new Size(372, 470);
		ac.TabIndex = 0;
		k.Dock = DockStyle.Bottom;
		k.Image = Resources.NizAll;
		k.Location = new Point(0, 989);
		k.Name = "Niz";
		k.Size = new Size(1280, 35);
		k.SizeMode = PictureBoxSizeMode.StretchImage;
		k.TabIndex = 4;
		k.TabStop = false;
		l.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		l.BackColor = Color.FromArgb(27, 35, 165);
		l.Location = new Point(10, 90);
		l.Name = "Goriz1";
		l.Size = new Size(1260, 2);
		l.TabIndex = 0;
		m.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		m.BackColor = Color.FromArgb(27, 35, 165);
		m.Location = new Point(10, 90);
		m.Name = "Vert1";
		m.Size = new Size(4, 879);
		m.TabIndex = 0;
		n.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		n.BackColor = Color.FromArgb(27, 35, 165);
		n.Location = new Point(880, 90);
		n.Name = "Vert2";
		n.Size = new Size(4, 879);
		n.TabIndex = 1;
		o.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		o.BackColor = Color.FromArgb(27, 35, 165);
		o.Location = new Point(10, 969);
		o.Name = "Goriz2";
		o.Size = new Size(1260, 2);
		o.TabIndex = 1;
		p.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		p.BackColor = Color.FromArgb(27, 35, 165);
		p.Location = new Point(1266, 90);
		p.Name = "Vert3";
		p.Size = new Size(4, 879);
		p.TabIndex = 2;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(190, 190, 190);
		base.ClientSize = new Size(1280, 1024);
		base.Controls.Add(o);
		base.Controls.Add(l);
		base.Controls.Add(k);
		base.Controls.Add(h);
		base.Controls.Add(g);
		base.Controls.Add(p);
		base.Controls.Add(n);
		base.Controls.Add(m);
		base.Controls.Add(i);
		base.Controls.Add(j);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "Boot_BootDevicePriority_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Boot_BootDevicePriority_Form";
		base.WindowState = FormWindowState.Maximized;
		base.FormClosing += a;
		base.KeyDown += a;
		((ISupportInitialize)g).EndInit();
		((ISupportInitialize)h).EndInit();
		i.ResumeLayout(performLayout: false);
		i.PerformLayout();
		j.ResumeLayout(performLayout: false);
		((ISupportInitialize)k).EndInit();
		ResumeLayout(performLayout: false);
	}
}
