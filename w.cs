using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MyBIOS.Properties;

public class w : Form
{
	private const int m_a = 6;

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

	private Label m_w;

	private Label x;

	private Label y;

	private Label z;

	private Label aa;

	private Label ab;

	private Label ac;

	private Label ad;

	private Label ae;

	private Label af;

	private Label ag;

	private Label ah;

	private Label ai;

	public w(u A_0)
	{
		this.m_b = A_0;
		a();
		d();
		c();
	}

	private void d()
	{
		ad.Text = this.m_b.k(this.m_b.l3);
		ab.Text = this.m_b.k(this.m_b.l6);
		z.Text = this.m_b.k(this.m_b.l9);
		x.Text = this.m_b.k(this.m_b.mc);
		v.Text = this.m_b.k(this.m_b.mf);
		ag.Text = this.m_b.k(this.m_b.mi);
		ae.Text = this.m_b.k(this.m_b.ml);
		ah.Text = this.m_b.o;
	}

	private void c()
	{
		foreach (Control control in i.Controls)
		{
			if (control.Name != "BootSettingsConfiguration_shapka")
			{
				control.ForeColor = this.m_b.g;
			}
		}
		switch (this.m_d)
		{
		case 0:
			ai.Text = this.m_b.l5;
			t.ForeColor = Color.White;
			ad.ForeColor = Color.White;
			break;
		case 1:
			ai.Text = this.m_b.l8;
			ac.ForeColor = Color.White;
			ab.ForeColor = Color.White;
			break;
		case 2:
			ai.Text = this.m_b.mb;
			aa.ForeColor = Color.White;
			z.ForeColor = Color.White;
			break;
		case 3:
			ai.Text = this.m_b.me;
			y.ForeColor = Color.White;
			x.ForeColor = Color.White;
			break;
		case 4:
			ai.Text = this.m_b.mh;
			m_w.ForeColor = Color.White;
			v.ForeColor = Color.White;
			break;
		case 5:
			ai.Text = this.m_b.mk;
			u.ForeColor = Color.White;
			ag.ForeColor = Color.White;
			break;
		case 6:
			ai.Text = this.m_b.mn;
			af.ForeColor = Color.White;
			ae.ForeColor = Color.White;
			break;
		}
	}

	private void b()
	{
		switch (this.m_d)
		{
		case 0:
			this.m_c = new ac(this.m_b, this.m_b.l3, this.m_b.l4);
			this.m_c.ShowDialog();
			this.m_b.l3 = this.m_b.m;
			break;
		case 1:
			this.m_c = new ac(this.m_b, this.m_b.l6, this.m_b.l7);
			this.m_c.ShowDialog();
			this.m_b.l6 = this.m_b.m;
			break;
		case 2:
			this.m_c = new ac(this.m_b, this.m_b.l9, this.m_b.ma);
			this.m_c.ShowDialog();
			this.m_b.l9 = this.m_b.m;
			break;
		case 3:
			this.m_c = new ac(this.m_b, this.m_b.mc, this.m_b.md);
			this.m_c.ShowDialog();
			this.m_b.mc = this.m_b.m;
			break;
		case 4:
			this.m_c = new ac(this.m_b, this.m_b.mf, this.m_b.mg);
			this.m_c.ShowDialog();
			this.m_b.mf = this.m_b.m;
			break;
		case 5:
			this.m_c = new ac(this.m_b, this.m_b.mi, this.m_b.mj);
			this.m_c.ShowDialog();
			this.m_b.mi = this.m_b.m;
			break;
		case 6:
			this.m_c = new ac(this.m_b, this.m_b.ml, this.m_b.mm);
			this.m_c.ShowDialog();
			this.m_b.ml = this.m_b.m;
			break;
		}
		d();
	}

	private void a(bool A_0)
	{
		switch (this.m_d)
		{
		case 0:
			this.m_b.k(ref this.m_b.l3, this.m_b.l4, A_0);
			break;
		case 1:
			this.m_b.k(ref this.m_b.l6, this.m_b.l7, A_0);
			break;
		case 2:
			this.m_b.k(ref this.m_b.l9, this.m_b.ma, A_0);
			break;
		case 3:
			this.m_b.k(ref this.m_b.mc, this.m_b.md, A_0);
			break;
		case 4:
			this.m_b.k(ref this.m_b.mf, this.m_b.mg, A_0);
			break;
		case 5:
			this.m_b.k(ref this.m_b.mi, this.m_b.mj, A_0);
			break;
		case 6:
			this.m_b.k(ref this.m_b.ml, this.m_b.mm, A_0);
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
		else if (A_1.KeyCode == Keys.Down && this.m_d < 6)
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
			this.m_d = 6;
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
		ae = new Label();
		af = new Label();
		ag = new Label();
		u = new Label();
		v = new Label();
		m_w = new Label();
		x = new Label();
		y = new Label();
		z = new Label();
		aa = new Label();
		ab = new Label();
		ac = new Label();
		ad = new Label();
		t = new Label();
		s = new Label();
		r = new Label();
		q = new Panel();
		j = new Panel();
		ah = new Label();
		ai = new Label();
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
		i.Controls.Add(ae);
		i.Controls.Add(af);
		i.Controls.Add(ag);
		i.Controls.Add(u);
		i.Controls.Add(v);
		i.Controls.Add(m_w);
		i.Controls.Add(x);
		i.Controls.Add(y);
		i.Controls.Add(z);
		i.Controls.Add(aa);
		i.Controls.Add(ab);
		i.Controls.Add(ac);
		i.Controls.Add(ad);
		i.Controls.Add(t);
		i.Controls.Add(s);
		i.Controls.Add(r);
		i.Controls.Add(q);
		i.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		i.ForeColor = Color.FromArgb(27, 35, 165);
		i.Location = new Point(12, 92);
		i.Name = "Lev_Panel";
		i.Size = new Size(868, 877);
		i.TabIndex = 2;
		ae.Anchor = AnchorStyles.Top;
		ae.AutoSize = true;
		ae.Location = new Point(474, 290);
		ae.Name = "Interrupt19Capture_Value";
		ae.Size = new Size(97, 34);
		ae.TabIndex = 58;
		ae.Text = "label1";
		af.AutoSize = true;
		af.Location = new Point(22, 290);
		af.Name = "Interrupt19Capture";
		af.Size = new Size(293, 34);
		af.TabIndex = 57;
		af.Text = "Interrupt 19 Capture";
		ag.Anchor = AnchorStyles.Top;
		ag.AutoSize = true;
		ag.Location = new Point(474, 256);
		ag.Name = "HitDELMessageDisplay_Value";
		ag.Size = new Size(97, 34);
		ag.TabIndex = 56;
		ag.Text = "label1";
		u.AutoSize = true;
		u.Location = new Point(22, 256);
		u.Name = "HitDELMessageDisplay";
		u.Size = new Size(376, 34);
		u.TabIndex = 55;
		u.Text = "Hit 'DEL' Message Display";
		v.Anchor = AnchorStyles.Top;
		v.AutoSize = true;
		v.Location = new Point(474, 222);
		v.Name = "WaitForF1IfError_Value";
		v.Size = new Size(97, 34);
		v.TabIndex = 54;
		v.Text = "label1";
		m_w.AutoSize = true;
		m_w.Location = new Point(22, 222);
		m_w.Name = "WaitForF1IfError";
		m_w.Size = new Size(290, 34);
		m_w.TabIndex = 53;
		m_w.Text = "Wait For 'F1' If Error";
		x.Anchor = AnchorStyles.Top;
		x.AutoSize = true;
		x.Location = new Point(474, 188);
		x.Name = "BootupNumLock_Value";
		x.Size = new Size(97, 34);
		x.TabIndex = 52;
		x.Text = "label1";
		y.AutoSize = true;
		y.Location = new Point(22, 188);
		y.Name = "BootupNumLock";
		y.Size = new Size(268, 34);
		y.TabIndex = 51;
		y.Text = "Bootup Num-Lock";
		z.Anchor = AnchorStyles.Top;
		z.AutoSize = true;
		z.Location = new Point(474, 154);
		z.Name = "AddOnROMDisplayMode_Value";
		z.Size = new Size(97, 34);
		z.TabIndex = 50;
		z.Text = "label1";
		aa.AutoSize = true;
		aa.Location = new Point(22, 154);
		aa.Name = "AddOnROMDisplayMode";
		aa.Size = new Size(382, 34);
		aa.TabIndex = 49;
		aa.Text = "AddOn ROM Display Mode";
		ab.Anchor = AnchorStyles.Top;
		ab.AutoSize = true;
		ab.Location = new Point(474, 120);
		ab.Name = "FullScreenLogo_Value";
		ab.Size = new Size(97, 34);
		ab.TabIndex = 48;
		ab.Text = "label1";
		ac.AutoSize = true;
		ac.Location = new Point(22, 120);
		ac.Name = "FullScreenLogo";
		ac.Size = new Size(251, 34);
		ac.TabIndex = 47;
		ac.Text = "Full Screen Logo";
		ad.Anchor = AnchorStyles.Top;
		ad.AutoSize = true;
		ad.Location = new Point(474, 86);
		ad.Name = "QuickBoot_Value";
		ad.Size = new Size(97, 34);
		ad.TabIndex = 46;
		ad.Text = "label1";
		t.AutoSize = true;
		t.Location = new Point(22, 86);
		t.Name = "QuickBoot";
		t.Size = new Size(169, 34);
		t.TabIndex = 45;
		t.Text = "Quick Boot";
		s.Location = new Point(700, 17);
		s.Name = "End";
		s.Size = new Size(126, 37);
		s.TabIndex = 44;
		r.AutoSize = true;
		r.ForeColor = Color.Black;
		r.Location = new Point(22, 17);
		r.Name = "BootSettingsConfiguration_shapka";
		r.Size = new Size(404, 34);
		r.TabIndex = 35;
		r.Text = "Boot Settings Configuration";
		q.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		q.BackColor = Color.FromArgb(27, 35, 165);
		q.Location = new Point(18, 68);
		q.Name = "Goriz_1";
		q.Size = new Size(828, 2);
		q.TabIndex = 1;
		j.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		j.AutoScroll = true;
		j.Controls.Add(ah);
		j.Controls.Add(ai);
		j.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		j.ForeColor = Color.FromArgb(27, 35, 165);
		j.Location = new Point(884, 92);
		j.Name = "Prav_Panel";
		j.Size = new Size(382, 877);
		j.TabIndex = 3;
		ah.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		ah.Location = new Point(6, 590);
		ah.Name = "Help_Niz";
		ah.Size = new Size(372, 250);
		ah.TabIndex = 1;
		ai.Location = new Point(6, 15);
		ai.Name = "Help_Verh";
		ai.Size = new Size(372, 470);
		ai.TabIndex = 0;
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
		base.Name = "Boot_BootSettingsConfiguration_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Boot_BootSettingsConfiguration_Form";
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
