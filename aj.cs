using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MyBIOS.Properties;

public class aj : Form
{
	private const int m_a = 1;

	private u m_b;

	private ac m_c;

	private int m_d;

	private bool e = true;

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

	public aj(u A_0)
	{
		this.m_b = A_0;
		a();
		d();
	}

	private void d()
	{
		if (this.m_b.ly == "Disabled" && this.m_b.lz != "Disabled")
		{
			this.m_b.ly = this.m_b.lz;
			this.m_b.lz = "Disabled";
		}
		else if (this.m_b.ly == this.m_b.lz && this.m_b.ly != "Disabled" && this.m_b.lz != "Disabled")
		{
			switch (this.m_d)
			{
			case 0:
				if (this.m_b.ly == this.m_b.l0[0])
				{
					this.m_b.lz = this.m_b.l0[1];
				}
				else
				{
					this.m_b.lz = this.m_b.l0[0];
				}
				break;
			case 1:
				if (this.m_b.lz == this.m_b.l0[0])
				{
					this.m_b.ly = this.m_b.l0[1];
				}
				else
				{
					this.m_b.ly = this.m_b.l0[0];
				}
				break;
			}
		}
		else if (this.m_b.ly == "Disabled" && this.m_b.lz == "Disabled")
		{
			u.Visible = false;
			t.Visible = false;
		}
		else
		{
			u.Visible = true;
			t.Visible = true;
		}
		v.Text = this.m_b.k(this.m_b.ly);
		t.Text = this.m_b.k(this.m_b.lz);
		y.Text = this.m_b.l1;
		x.Text = this.m_b.o;
		c();
	}

	private void c()
	{
		if (this.m_b.ly == "Disabled" && this.m_b.lz == "Disabled")
		{
			this.m_d = 0;
		}
		foreach (Control control in i.Controls)
		{
			if (control.Name != "HardDiskDrives_shapka")
			{
				control.ForeColor = this.m_b.g;
			}
		}
		switch (this.m_d)
		{
		case 0:
			w.ForeColor = Color.White;
			v.ForeColor = Color.White;
			break;
		case 1:
			u.ForeColor = Color.White;
			t.ForeColor = Color.White;
			break;
		}
	}

	private void b()
	{
		switch (this.m_d)
		{
		case 0:
			this.m_c = new ac(this.m_b, this.m_b.ly, this.m_b.l0);
			this.m_c.ShowDialog();
			this.m_b.ly = this.m_b.m;
			break;
		case 1:
			this.m_c = new ac(this.m_b, this.m_b.lz, this.m_b.l0);
			this.m_c.ShowDialog();
			this.m_b.lz = this.m_b.m;
			break;
		}
		d();
	}

	private void a(bool A_0)
	{
		string[] a_ = new string[2]
		{
			this.m_b.l0[0],
			this.m_b.l0[1]
		};
		switch (this.m_d)
		{
		case 0:
			this.m_b.k(ref this.m_b.ly, a_, A_0);
			break;
		case 1:
			this.m_b.k(ref this.m_b.lz, a_, A_0);
			break;
		}
		d();
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		if (A_1.KeyCode == Keys.Escape)
		{
			e = false;
			Close();
		}
		else if (A_1.KeyCode == Keys.Up && this.m_d > 0)
		{
			this.m_d--;
			c();
		}
		else if (A_1.KeyCode == Keys.Down && this.m_d < 1)
		{
			this.m_d++;
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
			this.m_d = 0;
			c();
		}
		else if (A_1.KeyCode == Keys.Next || A_1.KeyCode == Keys.End)
		{
			this.m_d = 1;
			c();
		}
		else if (A_1.KeyCode == Keys.F1)
		{
			this.m_b.ng();
		}
		else if (A_1.KeyCode == Keys.F5)
		{
			this.m_b.na();
			d();
		}
		else if (A_1.KeyCode == Keys.F7)
		{
			this.m_b.nd();
			d();
		}
		else if (A_1.KeyCode == Keys.F10)
		{
			this.m_b.l();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		A_1.Cancel = e;
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
		s = new Label();
		r = new Label();
		q = new Panel();
		j = new Panel();
		x = new Label();
		y = new Label();
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
		t.Location = new Point(328, 120);
		t.Name = "nd2Drive_Value";
		t.Size = new Size(97, 34);
		t.TabIndex = 52;
		t.Text = "label1";
		u.AutoSize = true;
		u.Location = new Point(22, 120);
		u.Name = "nd2Drive";
		u.Size = new Size(148, 34);
		u.TabIndex = 51;
		u.Text = "2nd Drive";
		v.Anchor = AnchorStyles.Top;
		v.AutoSize = true;
		v.Location = new Point(328, 86);
		v.Name = "st1Drive_Value";
		v.Size = new Size(97, 34);
		v.TabIndex = 50;
		v.Text = "label1";
		w.AutoSize = true;
		w.Location = new Point(22, 86);
		w.Name = "st1Drive";
		w.Size = new Size(138, 34);
		w.TabIndex = 49;
		w.Text = "1st Drive";
		s.Location = new Point(700, 17);
		s.Name = "End";
		s.Size = new Size(126, 37);
		s.TabIndex = 44;
		r.AutoSize = true;
		r.ForeColor = Color.Black;
		r.Location = new Point(22, 17);
		r.Name = "HardDiskDrives_shapka";
		r.Size = new Size(247, 34);
		r.TabIndex = 35;
		r.Text = "Hard Disk Drives";
		q.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		q.BackColor = Color.FromArgb(27, 35, 165);
		q.Location = new Point(18, 68);
		q.Name = "Goriz_1";
		q.Size = new Size(828, 2);
		q.TabIndex = 1;
		j.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		j.AutoScroll = true;
		j.Controls.Add(x);
		j.Controls.Add(y);
		j.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		j.ForeColor = Color.FromArgb(27, 35, 165);
		j.Location = new Point(884, 92);
		j.Name = "Prav_Panel";
		j.Size = new Size(382, 877);
		j.TabIndex = 3;
		x.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		x.Location = new Point(6, 590);
		x.Name = "Help_Niz";
		x.Size = new Size(372, 250);
		x.TabIndex = 1;
		y.Location = new Point(6, 15);
		y.Name = "Help_Verh";
		y.Size = new Size(372, 470);
		y.TabIndex = 0;
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
		base.Name = "Boot_HardDiskDrives_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Boot_HardDiskDrives_Form";
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
