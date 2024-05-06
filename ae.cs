using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MyBIOS.Properties;

public class ae : Form
{
	private const int m_a = 6;

	private u m_b;

	private ac m_c;

	private int m_d;

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

	private Panel y;

	private Label z;

	private Label aa;

	private Label ab;

	private Label ac;

	private Label ad;

	private Label m_ae;

	private Label af;

	private Label ag;

	private Label ah;

	private Label ai;

	private Label aj;

	private Label ak;

	private Label al;

	private Label am;

	private Label an;

	private Label ao;

	private Label ap;

	private Label aq;

	private Label ar;

	private Label @as;

	private Label at;

	private Label au;

	private Label av;

	private Label aw;

	private Label ax;

	private Label ay;

	private Label az;

	private Label a0;

	private Label a1;

	public ae(u A_0)
	{
		this.m_b = A_0;
		a();
		e();
		c();
	}

	private void e()
	{
		if (this.m_b.br == "Not Installed")
		{
			this.m_b.ap = (this.m_b.bi = "Not Detected");
			ag.Visible = false;
			am.Visible = false;
			af.Visible = false;
			al.Visible = false;
			m_ae.Visible = false;
			ak.Visible = false;
			ad.Visible = false;
			aj.Visible = false;
			ac.Visible = false;
			ai.Visible = false;
			ab.Visible = false;
			ao.Visible = false;
		}
		else
		{
			ag.Visible = true;
			am.Visible = true;
			af.Visible = true;
			al.Visible = true;
			m_ae.Visible = true;
			ak.Visible = true;
			ad.Visible = true;
			aj.Visible = true;
			ac.Visible = true;
			ai.Visible = true;
			ab.Visible = true;
			ao.Visible = true;
		}
		int num = ah.Location.X;
		int num2 = an.Location.X;
		int num3 = 0;
		if (this.m_b.bi == "Not Detected")
		{
			num3 = 150;
			w.Visible = false;
			aw.Visible = false;
			v.Visible = false;
			av.Visible = false;
			u.Visible = false;
			au.Visible = false;
			t.Visible = false;
			at.Visible = false;
			s.Visible = false;
			@as.Visible = false;
			r.Visible = false;
			ar.Visible = false;
			aa.Visible = false;
			aq.Visible = false;
			z.Visible = false;
			ap.Visible = false;
			y.Location = new Point(18, 130);
		}
		else
		{
			num3 = 427;
			w.Visible = true;
			aw.Visible = true;
			v.Visible = true;
			av.Visible = true;
			u.Visible = true;
			au.Visible = true;
			t.Visible = true;
			at.Visible = true;
			s.Visible = true;
			@as.Visible = true;
			r.Visible = true;
			ar.Visible = true;
			aa.Visible = true;
			aq.Visible = true;
			z.Visible = true;
			ap.Visible = true;
			y.Location = new Point(18, 408);
		}
		ah.Location = new Point(num, num3);
		an.Location = new Point(num2, num3);
		ag.Location = new Point(num, num3 += 34);
		am.Location = new Point(num2, num3);
		af.Location = new Point(num, num3 += 34);
		al.Location = new Point(num2, num3);
		m_ae.Location = new Point(num, num3 += 34);
		ak.Location = new Point(num2, num3);
		ad.Location = new Point(num, num3 += 34);
		aj.Location = new Point(num2, num3);
		ac.Location = new Point(num, num3 += 34);
		ai.Location = new Point(num2, num3);
		ab.Location = new Point(num, num3 += 34);
		ao.Location = new Point(num2, num3);
		ax.Text = ":" + this.m_b.bi;
		aw.Text = ":" + this.m_b.bj;
		av.Text = ":" + this.m_b.bk;
		au.Text = ":" + this.m_b.bl;
		at.Text = ":" + this.m_b.bm;
		@as.Text = ":" + this.m_b.bn;
		ar.Text = ":" + this.m_b.bo;
		aq.Text = ":" + this.m_b.bp;
		ap.Text = ":" + this.m_b.bq;
		an.Text = this.m_b.k(this.m_b.br);
		am.Text = this.m_b.k(this.m_b.bt);
		al.Text = this.m_b.k(this.m_b.bv);
		ak.Text = this.m_b.k(this.m_b.bx);
		aj.Text = this.m_b.k(this.m_b.bz);
		ai.Text = this.m_b.k(this.m_b.b1);
		ao.Text = this.m_b.k(this.m_b.b3);
		a1.Text = this.m_b.o;
		d();
	}

	private void d()
	{
		if (this.m_d < 3)
		{
			i.ScrollControlIntoView(ay);
		}
		else
		{
			i.ScrollControlIntoView(ab);
		}
	}

	private void c()
	{
		if (this.m_b.br == "Not Installed" && this.m_d != 0)
		{
			this.m_d = 0;
			return;
		}
		ah.ForeColor = this.m_b.g;
		an.ForeColor = this.m_b.g;
		ag.ForeColor = this.m_b.g;
		am.ForeColor = this.m_b.g;
		af.ForeColor = this.m_b.g;
		al.ForeColor = this.m_b.g;
		m_ae.ForeColor = this.m_b.g;
		ak.ForeColor = this.m_b.g;
		ad.ForeColor = this.m_b.g;
		aj.ForeColor = this.m_b.g;
		ac.ForeColor = this.m_b.g;
		ai.ForeColor = this.m_b.g;
		ab.ForeColor = this.m_b.g;
		ao.ForeColor = this.m_b.g;
		switch (this.m_d)
		{
		case 0:
			a0.Text = this.m_b.dh;
			ah.ForeColor = Color.White;
			an.ForeColor = Color.White;
			break;
		case 1:
			a0.Text = this.m_b.di;
			ag.ForeColor = Color.White;
			am.ForeColor = Color.White;
			break;
		case 2:
			a0.Text = this.m_b.dj;
			af.ForeColor = Color.White;
			al.ForeColor = Color.White;
			break;
		case 3:
			a0.Text = this.m_b.dk;
			m_ae.ForeColor = Color.White;
			ak.ForeColor = Color.White;
			break;
		case 4:
			a0.Text = this.m_b.dl;
			ad.ForeColor = Color.White;
			aj.ForeColor = Color.White;
			break;
		case 5:
			a0.Text = this.m_b.dm;
			ac.ForeColor = Color.White;
			ai.ForeColor = Color.White;
			break;
		case 6:
			a0.Text = this.m_b.dn;
			ab.ForeColor = Color.White;
			ao.ForeColor = Color.White;
			break;
		}
		d();
	}

	private void b()
	{
		switch (this.m_d)
		{
		case 0:
			this.m_c = new ac(this.m_b, this.m_b.br, this.m_b.bs);
			this.m_c.ShowDialog();
			this.m_b.br = this.m_b.m;
			break;
		case 1:
			this.m_c = new ac(this.m_b, this.m_b.bt, this.m_b.bu);
			this.m_c.ShowDialog();
			this.m_b.bt = this.m_b.m;
			break;
		case 2:
			this.m_c = new ac(this.m_b, this.m_b.bv, this.m_b.bw);
			this.m_c.ShowDialog();
			this.m_b.bv = this.m_b.m;
			break;
		case 3:
			this.m_c = new ac(this.m_b, this.m_b.bx, this.m_b.by);
			this.m_c.ShowDialog();
			this.m_b.bx = this.m_b.m;
			break;
		case 4:
			this.m_c = new ac(this.m_b, this.m_b.bz, this.m_b.b0);
			this.m_c.ShowDialog();
			this.m_b.bz = this.m_b.m;
			break;
		case 5:
			this.m_c = new ac(this.m_b, this.m_b.b1, this.m_b.b2);
			this.m_c.ShowDialog();
			this.m_b.b1 = this.m_b.m;
			break;
		case 6:
			this.m_c = new ac(this.m_b, this.m_b.b3, this.m_b.b4);
			this.m_c.ShowDialog();
			this.m_b.b3 = this.m_b.m;
			break;
		}
		e();
	}

	private void a(bool A_0)
	{
		switch (this.m_d)
		{
		case 0:
			this.m_b.k(ref this.m_b.br, this.m_b.bs, A_0);
			break;
		case 1:
			this.m_b.k(ref this.m_b.bt, this.m_b.bu, A_0);
			break;
		case 2:
			this.m_b.k(ref this.m_b.bv, this.m_b.bw, A_0);
			break;
		case 3:
			this.m_b.k(ref this.m_b.bx, this.m_b.by, A_0);
			break;
		case 4:
			this.m_b.k(ref this.m_b.bz, this.m_b.b0, A_0);
			break;
		case 5:
			this.m_b.k(ref this.m_b.b1, this.m_b.b2, A_0);
			break;
		case 6:
			this.m_b.k(ref this.m_b.b3, this.m_b.b4, A_0);
			break;
		}
		e();
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		if (A_1.KeyCode == Keys.Escape)
		{
			this.m_e = false;
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
		else if (A_1.KeyCode == Keys.Add || A_1.KeyCode == Keys.Oemplus)
		{
			a(A_0: true);
		}
		else if (A_1.KeyCode == Keys.Subtract || A_1.KeyCode == Keys.OemMinus)
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
			e();
		}
		else if (A_1.KeyCode == Keys.F7)
		{
			this.m_b.nd();
			e();
		}
		else if (A_1.KeyCode == Keys.F10)
		{
			this.m_b.l();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		A_1.Cancel = this.m_e;
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
		az = new Label();
		ay = new Label();
		ap = new Label();
		aq = new Label();
		ar = new Label();
		@as = new Label();
		at = new Label();
		au = new Label();
		av = new Label();
		aw = new Label();
		ax = new Label();
		ao = new Label();
		ai = new Label();
		aj = new Label();
		ak = new Label();
		al = new Label();
		am = new Label();
		an = new Label();
		ab = new Label();
		ac = new Label();
		ad = new Label();
		m_ae = new Label();
		af = new Label();
		ag = new Label();
		ah = new Label();
		z = new Label();
		aa = new Label();
		r = new Label();
		s = new Label();
		t = new Label();
		u = new Label();
		v = new Label();
		w = new Label();
		x = new Label();
		q = new Panel();
		y = new Panel();
		j = new Panel();
		a1 = new Label();
		a0 = new Label();
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
		h.Image = Resources.MainOnly;
		h.Location = new Point(0, 35);
		h.Name = "VerhMenu";
		h.Size = new Size(1280, 35);
		h.SizeMode = PictureBoxSizeMode.StretchImage;
		h.TabIndex = 1;
		h.TabStop = false;
		i.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		i.AutoScroll = true;
		i.BackColor = Color.FromArgb(190, 190, 190);
		i.Controls.Add(az);
		i.Controls.Add(ay);
		i.Controls.Add(ap);
		i.Controls.Add(aq);
		i.Controls.Add(ar);
		i.Controls.Add(@as);
		i.Controls.Add(at);
		i.Controls.Add(au);
		i.Controls.Add(av);
		i.Controls.Add(aw);
		i.Controls.Add(ax);
		i.Controls.Add(ao);
		i.Controls.Add(ai);
		i.Controls.Add(aj);
		i.Controls.Add(ak);
		i.Controls.Add(al);
		i.Controls.Add(am);
		i.Controls.Add(an);
		i.Controls.Add(ab);
		i.Controls.Add(ac);
		i.Controls.Add(ad);
		i.Controls.Add(m_ae);
		i.Controls.Add(af);
		i.Controls.Add(ag);
		i.Controls.Add(ah);
		i.Controls.Add(z);
		i.Controls.Add(aa);
		i.Controls.Add(r);
		i.Controls.Add(s);
		i.Controls.Add(t);
		i.Controls.Add(u);
		i.Controls.Add(v);
		i.Controls.Add(w);
		i.Controls.Add(x);
		i.Controls.Add(q);
		i.Controls.Add(y);
		i.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		i.ForeColor = Color.FromArgb(27, 35, 165);
		i.Location = new Point(12, 92);
		i.Name = "Lev_Panel";
		i.Size = new Size(868, 877);
		i.TabIndex = 2;
		az.Location = new Point(700, 680);
		az.Name = "End";
		az.Size = new Size(126, 37);
		az.TabIndex = 36;
		ay.AutoSize = true;
		ay.ForeColor = Color.Black;
		ay.Location = new Point(22, 17);
		ay.Name = "SATA2";
		ay.Size = new Size(109, 34);
		ay.TabIndex = 35;
		ay.Text = "SATA 2";
		ap.AutoSize = true;
		ap.ForeColor = Color.FromArgb(64, 64, 64);
		ap.Location = new Point(295, 354);
		ap.Name = "SMART_INFO_VALUE";
		ap.Size = new Size(97, 34);
		ap.TabIndex = 34;
		ap.Text = "label9";
		aq.AutoSize = true;
		aq.ForeColor = Color.FromArgb(64, 64, 64);
		aq.Location = new Point(192, 320);
		aq.Name = "UltraDMA_INFO_VALUE";
		aq.Size = new Size(97, 34);
		aq.TabIndex = 33;
		aq.Text = "label8";
		ar.AutoSize = true;
		ar.ForeColor = Color.FromArgb(64, 64, 64);
		ar.Location = new Point(192, 286);
		ar.Name = "AsyncDMA_INFO_VALUE";
		ar.Size = new Size(97, 34);
		ar.TabIndex = 32;
		ar.Text = "label7";
		@as.AutoSize = true;
		@as.ForeColor = Color.FromArgb(64, 64, 64);
		@as.Location = new Point(192, 252);
		@as.Name = "PIOMode_INFO_VALUE";
		@as.Size = new Size(97, 34);
		@as.TabIndex = 31;
		@as.Text = "label6";
		at.AutoSize = true;
		at.ForeColor = Color.FromArgb(64, 64, 64);
		at.Location = new Point(192, 218);
		at.Name = "Block_INFO_VALUE";
		at.Size = new Size(97, 34);
		at.TabIndex = 30;
		at.Text = "label5";
		au.AutoSize = true;
		au.ForeColor = Color.FromArgb(64, 64, 64);
		au.Location = new Point(192, 184);
		au.Name = "LBA_INFO_VALUE";
		au.Size = new Size(97, 34);
		au.TabIndex = 29;
		au.Text = "label4";
		av.AutoSize = true;
		av.ForeColor = Color.FromArgb(64, 64, 64);
		av.Location = new Point(192, 150);
		av.Name = "Size_INFO_VALUE";
		av.Size = new Size(97, 34);
		av.TabIndex = 28;
		av.Text = "label3";
		aw.AutoSize = true;
		aw.ForeColor = Color.FromArgb(64, 64, 64);
		aw.Location = new Point(192, 116);
		aw.Name = "Vendor_INFO_VALUE";
		aw.Size = new Size(97, 34);
		aw.TabIndex = 27;
		aw.Text = "label2";
		ax.AutoSize = true;
		ax.ForeColor = Color.FromArgb(64, 64, 64);
		ax.Location = new Point(192, 82);
		ax.Name = "Device_INFO_VALUE";
		ax.Size = new Size(97, 34);
		ax.TabIndex = 26;
		ax.Text = "label1";
		ao.Anchor = AnchorStyles.Top;
		ao.AutoSize = true;
		ao.Location = new Point(492, 631);
		ao.Name = "BitDataTransfer_Value";
		ao.Size = new Size(97, 34);
		ao.TabIndex = 25;
		ao.Text = "label7";
		ai.Anchor = AnchorStyles.Top;
		ai.AutoSize = true;
		ai.Location = new Point(492, 597);
		ai.Name = "SMART_Value";
		ai.Size = new Size(97, 34);
		ai.TabIndex = 24;
		ai.Text = "label6";
		aj.Anchor = AnchorStyles.Top;
		aj.AutoSize = true;
		aj.Location = new Point(492, 563);
		aj.Name = "DMAMode_Value";
		aj.Size = new Size(97, 34);
		aj.TabIndex = 23;
		aj.Text = "label5";
		ak.Anchor = AnchorStyles.Top;
		ak.AutoSize = true;
		ak.Location = new Point(492, 529);
		ak.Name = "PIOMode_Value";
		ak.Size = new Size(97, 34);
		ak.TabIndex = 22;
		ak.Text = "label4";
		al.Anchor = AnchorStyles.Top;
		al.AutoSize = true;
		al.Location = new Point(492, 495);
		al.Name = "Block_Value";
		al.Size = new Size(97, 34);
		al.TabIndex = 21;
		al.Text = "label3";
		am.Anchor = AnchorStyles.Top;
		am.AutoSize = true;
		am.Location = new Point(492, 461);
		am.Name = "LBA_Value";
		am.Size = new Size(97, 34);
		am.TabIndex = 20;
		am.Text = "label2";
		an.Anchor = AnchorStyles.Top;
		an.AutoSize = true;
		an.Location = new Point(492, 427);
		an.Name = "Type_Value";
		an.Size = new Size(97, 34);
		an.TabIndex = 19;
		an.Text = "label1";
		ab.AutoSize = true;
		ab.Location = new Point(22, 631);
		ab.Name = "BitDataTransfer";
		ab.Size = new Size(278, 34);
		ab.TabIndex = 18;
		ab.Text = "32Bit Data Transfer";
		ac.AutoSize = true;
		ac.Location = new Point(22, 597);
		ac.Name = "SMART";
		ac.Size = new Size(277, 34);
		ac.TabIndex = 17;
		ac.Text = "SMART Monitoring";
		ad.AutoSize = true;
		ad.Location = new Point(22, 563);
		ad.Name = "DMAMode";
		ad.Size = new Size(164, 34);
		ad.TabIndex = 16;
		ad.Text = "DMA Mode";
		m_ae.AutoSize = true;
		m_ae.Location = new Point(22, 529);
		m_ae.Name = "PIOMode";
		m_ae.Size = new Size(149, 34);
		m_ae.TabIndex = 15;
		m_ae.Text = "PIO Mode";
		af.AutoSize = true;
		af.Location = new Point(22, 495);
		af.Name = "Block";
		af.Size = new Size(404, 34);
		af.TabIndex = 14;
		af.Text = "Block(Multi-Sector Transfer)";
		ag.AutoSize = true;
		ag.Location = new Point(22, 461);
		ag.Name = "LBALargeMode";
		ag.Size = new Size(244, 34);
		ag.TabIndex = 13;
		ag.Text = "LBA/Large Mode";
		ah.AutoSize = true;
		ah.Location = new Point(22, 427);
		ah.Name = "Type";
		ah.Size = new Size(81, 34);
		ah.TabIndex = 12;
		ah.Text = "Type";
		z.AutoSize = true;
		z.ForeColor = Color.FromArgb(64, 64, 64);
		z.Location = new Point(22, 354);
		z.Name = "SMART_INFO";
		z.Size = new Size(277, 34);
		z.TabIndex = 11;
		z.Text = "SMART Monitoring";
		aa.AutoSize = true;
		aa.ForeColor = Color.FromArgb(64, 64, 64);
		aa.Location = new Point(22, 320);
		aa.Name = "UltraDMA_INFO";
		aa.Size = new Size(154, 34);
		aa.TabIndex = 10;
		aa.Text = "Ultra DMA";
		r.AutoSize = true;
		r.ForeColor = Color.FromArgb(64, 64, 64);
		r.Location = new Point(22, 286);
		r.Name = "AsyncDMA_INFO";
		r.Size = new Size(173, 34);
		r.TabIndex = 9;
		r.Text = "Async DMA";
		s.AutoSize = true;
		s.ForeColor = Color.FromArgb(64, 64, 64);
		s.Location = new Point(22, 252);
		s.Name = "PIOMode_INFO";
		s.Size = new Size(149, 34);
		s.TabIndex = 8;
		s.Text = "PIO Mode";
		t.AutoSize = true;
		t.ForeColor = Color.FromArgb(64, 64, 64);
		t.Location = new Point(22, 218);
		t.Name = "BlockMode_INFO";
		t.Size = new Size(178, 34);
		t.TabIndex = 7;
		t.Text = "Block Mode";
		u.AutoSize = true;
		u.ForeColor = Color.FromArgb(64, 64, 64);
		u.Location = new Point(22, 184);
		u.Name = "LBAMode_INFO";
		u.Size = new Size(156, 34);
		u.TabIndex = 6;
		u.Text = "LBA Mode";
		v.AutoSize = true;
		v.ForeColor = Color.FromArgb(64, 64, 64);
		v.Location = new Point(22, 150);
		v.Name = "Size_INFO";
		v.Size = new Size(73, 34);
		v.TabIndex = 5;
		v.Text = "Size";
		w.AutoSize = true;
		w.ForeColor = Color.FromArgb(64, 64, 64);
		w.Location = new Point(22, 116);
		w.Name = "Vendor_INFO";
		w.Size = new Size(113, 34);
		w.TabIndex = 4;
		w.Text = "Vendor";
		x.AutoSize = true;
		x.ForeColor = Color.FromArgb(64, 64, 64);
		x.Location = new Point(22, 82);
		x.Name = "Device_INFO";
		x.Size = new Size(109, 34);
		x.TabIndex = 3;
		x.Text = "Device";
		q.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		q.BackColor = Color.FromArgb(27, 35, 165);
		q.Location = new Point(18, 68);
		q.Name = "Goriz_1";
		q.Size = new Size(828, 2);
		q.TabIndex = 1;
		y.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		y.BackColor = Color.FromArgb(27, 35, 165);
		y.Location = new Point(18, 408);
		y.Name = "Goriz_2";
		y.Size = new Size(828, 2);
		y.TabIndex = 2;
		j.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		j.AutoScroll = true;
		j.Controls.Add(a1);
		j.Controls.Add(a0);
		j.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		j.ForeColor = Color.FromArgb(27, 35, 165);
		j.Location = new Point(884, 92);
		j.Name = "Prav_Panel";
		j.Size = new Size(382, 877);
		j.TabIndex = 3;
		a1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		a1.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		a1.ForeColor = Color.FromArgb(27, 35, 165);
		a1.Location = new Point(6, 590);
		a1.Name = "Help_Niz";
		a1.Size = new Size(372, 250);
		a1.TabIndex = 0;
		a0.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		a0.ForeColor = Color.FromArgb(27, 35, 165);
		a0.Location = new Point(6, 15);
		a0.Name = "Help_Verh";
		a0.Size = new Size(372, 470);
		a0.TabIndex = 1;
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
		base.Name = "Main_SATA2_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Main_SATA2_Form";
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
