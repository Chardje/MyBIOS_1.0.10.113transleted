using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MyBIOS.Properties;

public class r : Form
{
	private const int m_a = 4;

	private IContainer m_b;

	private PictureBox m_c;

	private PictureBox m_d;

	private Panel e;

	private Panel f;

	private PictureBox g;

	private Panel h;

	private Panel i;

	private Panel j;

	private Panel k;

	private Panel l;

	private Panel m;

	private Panel n;

	private Label o;

	private Label p;

	private Label q;

	private Label m_r;

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

	private u ad;

	private ac ae;

	private int af;

	private bool ag = true;

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.m_b != null)
		{
			this.m_b.Dispose();
		}
		base.Dispose(disposing);
	}

	private void d()
	{
		this.m_c = new PictureBox();
		this.m_d = new PictureBox();
		e = new Panel();
		aa = new Label();
		ab = new Label();
		ac = new Label();
		x = new Label();
		y = new Label();
		z = new Label();
		u = new Label();
		t = new Label();
		s = new Label();
		q = new Label();
		m_r = new Label();
		p = new Label();
		o = new Label();
		m = new Panel();
		n = new Panel();
		f = new Panel();
		v = new Label();
		w = new Label();
		g = new PictureBox();
		h = new Panel();
		i = new Panel();
		j = new Panel();
		k = new Panel();
		l = new Panel();
		((ISupportInitialize)this.m_c).BeginInit();
		((ISupportInitialize)this.m_d).BeginInit();
		e.SuspendLayout();
		f.SuspendLayout();
		((ISupportInitialize)g).BeginInit();
		SuspendLayout();
		this.m_c.Dock = DockStyle.Top;
		this.m_c.Image = Resources.ShapkaAll;
		this.m_c.Location = new Point(0, 0);
		this.m_c.Name = "Shapka";
		this.m_c.Size = new Size(1280, 35);
		this.m_c.SizeMode = PictureBoxSizeMode.StretchImage;
		this.m_c.TabIndex = 0;
		this.m_c.TabStop = false;
		this.m_d.Dock = DockStyle.Top;
		this.m_d.Image = Resources.BootOnly;
		this.m_d.Location = new Point(0, 35);
		this.m_d.Name = "VerhMenu";
		this.m_d.Size = new Size(1280, 35);
		this.m_d.SizeMode = PictureBoxSizeMode.StretchImage;
		this.m_d.TabIndex = 1;
		this.m_d.TabStop = false;
		e.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		e.AutoScroll = true;
		e.BackColor = Color.FromArgb(190, 190, 190);
		e.Controls.Add(aa);
		e.Controls.Add(ab);
		e.Controls.Add(ac);
		e.Controls.Add(x);
		e.Controls.Add(y);
		e.Controls.Add(z);
		e.Controls.Add(u);
		e.Controls.Add(t);
		e.Controls.Add(s);
		e.Controls.Add(q);
		e.Controls.Add(m_r);
		e.Controls.Add(p);
		e.Controls.Add(o);
		e.Controls.Add(m);
		e.Controls.Add(n);
		e.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		e.ForeColor = Color.FromArgb(27, 35, 165);
		e.Location = new Point(12, 92);
		e.Name = "Lev_Panel";
		e.Size = new Size(868, 877);
		e.TabIndex = 2;
		aa.Anchor = AnchorStyles.Top;
		aa.AutoSize = true;
		aa.Location = new Point(524, 327);
		aa.Name = "PasswordCheck_Value";
		aa.Size = new Size(97, 34);
		aa.TabIndex = 74;
		aa.Text = "label1";
		ab.AutoSize = true;
		ab.Location = new Point(22, 327);
		ab.Name = "PasswordCheck";
		ab.Size = new Size(247, 34);
		ab.TabIndex = 72;
		ab.Text = "Password Check";
		ac.AutoSize = true;
		ac.Location = new Point(22, 293);
		ac.Name = "ClearUserPassword";
		ac.Size = new Size(304, 34);
		ac.TabIndex = 71;
		ac.Text = "Clear User Password";
		x.Anchor = AnchorStyles.Top;
		x.AutoSize = true;
		x.Location = new Point(524, 225);
		x.Name = "UserAccessLevel_Value";
		x.Size = new Size(97, 34);
		x.TabIndex = 69;
		x.Text = "label1";
		y.AutoSize = true;
		y.Location = new Point(22, 259);
		y.Name = "ChangeUserPassword";
		y.Size = new Size(339, 34);
		y.TabIndex = 68;
		y.Text = "Change User Password";
		z.AutoSize = true;
		z.Location = new Point(22, 225);
		z.Name = "UserAccessLevel";
		z.Size = new Size(268, 34);
		z.TabIndex = 67;
		z.Text = "User Access Level";
		u.Location = new Point(720, 117);
		u.Name = "End";
		u.Size = new Size(126, 37);
		u.TabIndex = 66;
		t.AutoSize = true;
		t.Location = new Point(22, 191);
		t.Name = "ChangeSupervisorPassword";
		t.Size = new Size(427, 34);
		t.TabIndex = 54;
		t.Text = "Change Supervisor Password";
		s.AutoSize = true;
		s.ForeColor = Color.FromArgb(64, 64, 64);
		s.Location = new Point(357, 117);
		s.Name = "UserPassword_INFO_Value";
		s.Size = new Size(97, 34);
		s.TabIndex = 46;
		s.Text = "label1";
		q.AutoSize = true;
		q.ForeColor = Color.FromArgb(64, 64, 64);
		q.Location = new Point(22, 117);
		q.Name = "UserPassword_INFO";
		q.Size = new Size(224, 34);
		q.TabIndex = 38;
		q.Text = "User Password";
		m_r.AutoSize = true;
		m_r.ForeColor = Color.FromArgb(64, 64, 64);
		m_r.Location = new Point(357, 83);
		m_r.Name = "SupervisorPassword_INFO_Value";
		m_r.Size = new Size(97, 34);
		m_r.TabIndex = 37;
		m_r.Text = "label1";
		p.AutoSize = true;
		p.ForeColor = Color.FromArgb(64, 64, 64);
		p.Location = new Point(22, 83);
		p.Name = "SupervisorPassword_INFO";
		p.Size = new Size(312, 34);
		p.TabIndex = 36;
		p.Text = "Supervisor Password";
		o.AutoSize = true;
		o.ForeColor = Color.Black;
		o.Location = new Point(22, 17);
		o.Name = "SecuritySettings";
		o.Size = new Size(252, 34);
		o.TabIndex = 35;
		o.Text = "Security Settings";
		m.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		m.BackColor = Color.FromArgb(27, 35, 165);
		m.Location = new Point(18, 68);
		m.Name = "Goriz_1";
		m.Size = new Size(828, 2);
		m.TabIndex = 1;
		n.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		n.BackColor = Color.FromArgb(27, 35, 165);
		n.Location = new Point(18, 166);
		n.Name = "Goriz_2";
		n.Size = new Size(828, 2);
		n.TabIndex = 2;
		f.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		f.AutoScroll = true;
		f.Controls.Add(v);
		f.Controls.Add(w);
		f.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		f.ForeColor = Color.FromArgb(27, 35, 165);
		f.Location = new Point(884, 92);
		f.Name = "Prav_Panel";
		f.Size = new Size(382, 877);
		f.TabIndex = 3;
		v.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		v.Location = new Point(6, 590);
		v.Name = "Help_Niz";
		v.Size = new Size(372, 250);
		v.TabIndex = 1;
		w.Location = new Point(6, 15);
		w.Name = "Help_Verh";
		w.Size = new Size(372, 470);
		w.TabIndex = 0;
		g.Dock = DockStyle.Bottom;
		g.Image = Resources.NizAll;
		g.Location = new Point(0, 989);
		g.Name = "Niz";
		g.Size = new Size(1280, 35);
		g.SizeMode = PictureBoxSizeMode.StretchImage;
		g.TabIndex = 4;
		g.TabStop = false;
		h.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		h.BackColor = Color.FromArgb(27, 35, 165);
		h.Location = new Point(10, 90);
		h.Name = "Goriz1";
		h.Size = new Size(1260, 2);
		h.TabIndex = 0;
		i.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		i.BackColor = Color.FromArgb(27, 35, 165);
		i.Location = new Point(10, 90);
		i.Name = "Vert1";
		i.Size = new Size(4, 879);
		i.TabIndex = 0;
		j.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		j.BackColor = Color.FromArgb(27, 35, 165);
		j.Location = new Point(880, 90);
		j.Name = "Vert2";
		j.Size = new Size(4, 879);
		j.TabIndex = 1;
		k.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		k.BackColor = Color.FromArgb(27, 35, 165);
		k.Location = new Point(10, 969);
		k.Name = "Goriz2";
		k.Size = new Size(1260, 2);
		k.TabIndex = 1;
		l.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		l.BackColor = Color.FromArgb(27, 35, 165);
		l.Location = new Point(1266, 90);
		l.Name = "Vert3";
		l.Size = new Size(4, 879);
		l.TabIndex = 2;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(190, 190, 190);
		base.ClientSize = new Size(1280, 1024);
		base.Controls.Add(k);
		base.Controls.Add(h);
		base.Controls.Add(g);
		base.Controls.Add(this.m_d);
		base.Controls.Add(this.m_c);
		base.Controls.Add(l);
		base.Controls.Add(j);
		base.Controls.Add(i);
		base.Controls.Add(e);
		base.Controls.Add(f);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "Boot_Security_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Boot_Security_Form";
		base.WindowState = FormWindowState.Maximized;
		base.FormClosing += a;
		base.KeyDown += a;
		((ISupportInitialize)this.m_c).EndInit();
		((ISupportInitialize)this.m_d).EndInit();
		e.ResumeLayout(performLayout: false);
		e.PerformLayout();
		f.ResumeLayout(performLayout: false);
		((ISupportInitialize)g).EndInit();
		ResumeLayout(performLayout: false);
	}

	public r(u A_0)
	{
		ad = A_0;
		d();
		c();
		b();
	}

	private void c()
	{
		int num = ab.Location.X;
		int num2 = aa.Location.X;
		int num3 = 0;
		if (string.IsNullOrEmpty(ad.mo))
		{
			m_r.Text = ":Not Installed";
			z.Visible = false;
			x.Visible = false;
			num3 = z.Location.Y;
		}
		else
		{
			m_r.Text = ":Installed";
			z.Visible = true;
			x.Visible = true;
			num3 = z.Location.Y + 34;
		}
		y.Location = new Point(num, num3);
		ac.Location = new Point(num, num3 += 34);
		if (string.IsNullOrEmpty(ad.mp))
		{
			s.Text = ":Not Installed";
			ac.Visible = false;
			num3 = ac.Location.Y;
		}
		else
		{
			s.Text = ":Installed";
			ac.Visible = true;
			num3 = ac.Location.Y + 34;
		}
		ab.Location = new Point(num, num3);
		aa.Location = new Point(num2, num3);
		if (!string.IsNullOrEmpty(ad.mo) || !string.IsNullOrEmpty(ad.mp))
		{
			ab.Visible = true;
			aa.Visible = true;
		}
		else
		{
			ab.Visible = false;
			aa.Visible = false;
		}
		x.Text = ad.k(ad.mr);
		aa.Text = ad.k(ad.mv);
	}

	private void b(bool A_0)
	{
		string text = "";
		q q2 = new q(ad, "Enter Password:");
		q2.ShowDialog();
		if (ad.m == "Cancel")
		{
			return;
		}
		if (string.IsNullOrEmpty(ad.m))
		{
			if (A_0)
			{
				ad.mo = "";
			}
			else
			{
				ad.mp = "";
			}
			n n2 = new n(ad, "Password uninstalled.", A_2: false);
			n2.ShowDialog();
			return;
		}
		text = ad.m;
		q2 = new q(ad, "Confirm Password:");
		q2.ShowDialog();
		if (ad.m == "Cancel")
		{
			return;
		}
		if (ad.m == text)
		{
			if (A_0)
			{
				ad.mo = text;
			}
			else
			{
				ad.mp = text;
			}
			n n2 = new n(ad, "Password installed.", A_2: false);
			n2.ShowDialog();
		}
		else
		{
			n n2 = new n(ad, "Passwords do not match!", A_2: false);
			n2.ShowDialog();
		}
	}

	private void b()
	{
		t.ForeColor = ad.g;
		z.ForeColor = ad.g;
		x.ForeColor = ad.g;
		y.ForeColor = ad.g;
		ac.ForeColor = ad.g;
		ab.ForeColor = ad.g;
		aa.ForeColor = ad.g;
		if (string.IsNullOrEmpty(ad.mo) && string.IsNullOrEmpty(ad.mp) && af == 4)
		{
			af = 2;
		}
		switch (af)
		{
		case 0:
			w.Text = ad.mq;
			v.Text = ad.s;
			t.ForeColor = Color.White;
			break;
		case 1:
			w.Text = ad.mt;
			v.Text = ad.o;
			z.ForeColor = Color.White;
			x.ForeColor = Color.White;
			break;
		case 2:
			w.Text = ad.mq;
			v.Text = ad.p;
			y.ForeColor = Color.White;
			break;
		case 3:
			w.Text = ad.mu;
			v.Text = ad.p;
			ac.ForeColor = Color.White;
			break;
		case 4:
			w.Text = ad.mx;
			v.Text = ad.o;
			ab.ForeColor = Color.White;
			aa.ForeColor = Color.White;
			break;
		}
	}

	private void a()
	{
		switch (af)
		{
		case 0:
			b(A_0: true);
			break;
		case 1:
			ae = new ac(ad, ad.mr, ad.ms);
			ae.ShowDialog();
			ad.mr = ad.m;
			break;
		case 2:
			b(A_0: false);
			break;
		case 3:
		{
			n n2 = new n(ad, "Clear User Password?", A_2: true);
			n2.ShowDialog();
			if (ad.m == "Ok")
			{
				ad.mp = "";
			}
			af = 0;
			b();
			break;
		}
		case 4:
			ae = new ac(ad, ad.mv, ad.mw);
			ae.ShowDialog();
			ad.mv = ad.m;
			break;
		}
		c();
	}

	private void a(bool A_0)
	{
		switch (af)
		{
		case 1:
			ad.k(ref ad.mr, ad.ms, A_0);
			break;
		case 4:
			ad.k(ref ad.mv, ad.mw, A_0);
			break;
		}
		c();
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		if (A_1.KeyCode == Keys.Escape)
		{
			ag = false;
			Close();
		}
		else if (A_1.KeyCode == Keys.Up && af > 0)
		{
			af--;
			if (string.IsNullOrEmpty(ad.mo) && af == 1)
			{
				af--;
			}
			if (string.IsNullOrEmpty(ad.mp) && af == 3)
			{
				af--;
			}
			b();
		}
		else if (A_1.KeyCode == Keys.Down && af < 4)
		{
			af++;
			if (string.IsNullOrEmpty(ad.mo) && af == 1)
			{
				af++;
			}
			if (string.IsNullOrEmpty(ad.mp) && af == 3)
			{
				af++;
			}
			b();
		}
		else if (A_1.KeyCode == Keys.Add|| A_1.KeyCode == Keys.Oemplus)
		{
			a(A_0: true);
		}
		else if (A_1.KeyCode == Keys.Subtract|| A_1.KeyCode == Keys.OemMinus)
		{
			a(A_0: false);
		}
		else if (A_1.KeyCode == Keys.Return)
		{
			a();
		}
		else if (A_1.KeyCode == Keys.Prior || A_1.KeyCode == Keys.Home)
		{
			af = 0;
			b();
		}
		else if (A_1.KeyCode == Keys.Next || A_1.KeyCode == Keys.End)
		{
			af = 4;
			b();
		}
		else if (A_1.KeyCode == Keys.F1)
		{
			ad.ng();
		}
		else if (A_1.KeyCode == Keys.F5)
		{
			ad.na();
			c();
		}
		else if (A_1.KeyCode == Keys.F7)
		{
			ad.nd();
			c();
		}
		else if (A_1.KeyCode == Keys.F10)
		{
			ad.l();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		A_1.Cancel = ag;
	}
}
