using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MyBIOS.Properties;

public class ad : Form
{
	private const int m_a = 3;

	private IContainer m_b;

	private PictureBox m_c;

	private PictureBox d;

	private Panel e;

	private Panel f;

	private PictureBox g;

	private Panel h;

	private Panel i;

	private Panel j;

	private Panel k;

	private Panel l;

	private Label m;

	private Label n;

	private Label o;

	private Label p;

	private Label q;

	private Label r;

	private Label s;

	private u t;

	private a u;

	private int v;

	public bool w = true;

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.m_b != null)
		{
			this.m_b.Dispose();
		}
		base.Dispose(disposing);
	}

	private void c()
	{
		this.m_c = new PictureBox();
		d = new PictureBox();
		e = new Panel();
		n = new Label();
		o = new Label();
		p = new Label();
		m = new Label();
		f = new Panel();
		q = new Label();
		r = new Label();
		g = new PictureBox();
		h = new Panel();
		i = new Panel();
		j = new Panel();
		k = new Panel();
		l = new Panel();
		s = new Label();
		((ISupportInitialize)this.m_c).BeginInit();
		((ISupportInitialize)d).BeginInit();
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
		d.Dock = DockStyle.Top;
		d.Image = Resources.Exit;
		d.Location = new Point(0, 35);
		d.Name = "VerhMenu";
		d.Size = new Size(1280, 35);
		d.SizeMode = PictureBoxSizeMode.StretchImage;
		d.TabIndex = 1;
		d.TabStop = false;
		e.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		e.AutoScroll = true;
		e.BackColor = Color.FromArgb(190, 190, 190);
		e.Controls.Add(n);
		e.Controls.Add(o);
		e.Controls.Add(p);
		e.Controls.Add(m);
		e.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		e.ForeColor = Color.FromArgb(27, 35, 165);
		e.Location = new Point(12, 92);
		e.Name = "Lev_Panel";
		e.Size = new Size(868, 877);
		e.TabIndex = 2;
		n.AutoSize = true;
		n.Location = new Point(22, 183);
		n.Name = "LoadSetupDefaults";
		n.Size = new Size(297, 34);
		n.TabIndex = 3;
		n.Text = "Load Setup Defaults";
		o.AutoSize = true;
		o.Location = new Point(22, 118);
		o.Name = "DiscardChanges";
		o.Size = new Size(252, 34);
		o.TabIndex = 2;
		o.Text = "Discard Changes";
		p.AutoSize = true;
		p.Location = new Point(22, 84);
		p.Name = "ExitAndDiscardChanges";
		p.Size = new Size(342, 34);
		p.TabIndex = 1;
		p.Text = "Exit && Discard Changes";
		m.AutoSize = true;
		m.Location = new Point(22, 50);
		m.Name = "ExitAndSaveChanges";
		m.Size = new Size(304, 34);
		m.TabIndex = 0;
		m.Text = "Exit && Save Changes";
		f.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		f.AutoScroll = true;
		f.Controls.Add(q);
		f.Controls.Add(r);
		f.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		f.ForeColor = Color.FromArgb(27, 35, 165);
		f.Location = new Point(884, 92);
		f.Name = "Prav_Panel";
		f.Size = new Size(382, 877);
		f.TabIndex = 3;
		q.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		q.Location = new Point(6, 590);
		q.Name = "Help_Niz";
		q.Size = new Size(372, 250);
		q.TabIndex = 1;
		r.Location = new Point(6, 15);
		r.Name = "Help_Verh";
		r.Size = new Size(372, 470);
		r.TabIndex = 0;
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
		s.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		s.BackColor = Color.FromArgb(4, 7, 80);
		s.Cursor = Cursors.Hand;
		s.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Underline, GraphicsUnit.Point, 204);
		s.ForeColor = Color.FromArgb(224, 224, 224);
		s.Location = new Point(1125, 2);
		s.Name = "ShowQuestion";
		s.Size = new Size(155, 30);
		s.TabIndex = 6;
		s.Text = "Напомнить задание";
		s.TextAlign = ContentAlignment.MiddleCenter;
		s.Visible = false;
		s.MouseLeave += a;
		s.Click += c;
		s.MouseEnter += b;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(190, 190, 190);
		base.ClientSize = new Size(1280, 1024);
		base.Controls.Add(s);
		base.Controls.Add(k);
		base.Controls.Add(h);
		base.Controls.Add(g);
		base.Controls.Add(d);
		base.Controls.Add(this.m_c);
		base.Controls.Add(l);
		base.Controls.Add(j);
		base.Controls.Add(i);
		base.Controls.Add(e);
		base.Controls.Add(f);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "Exit_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Exit_Form";
		base.WindowState = FormWindowState.Maximized;
		base.FormClosing += a;
		base.KeyDown += a;
		((ISupportInitialize)this.m_c).EndInit();
		((ISupportInitialize)d).EndInit();
		e.ResumeLayout(performLayout: false);
		e.PerformLayout();
		f.ResumeLayout(performLayout: false);
		((ISupportInitialize)g).EndInit();
		ResumeLayout(performLayout: false);
	}

	public ad(u A_0)
	{
		t = A_0;
		c();
		if (t.h)
		{
			s.Visible = true;
		}
		q.Text = t.p;
		b();
	}

	private void b()
	{
		foreach (Label control in e.Controls)
		{
			control.ForeColor = t.g;
		}
		switch (v)
		{
		case 0:
			m.ForeColor = Color.White;
			r.Text = t.m0;
			break;
		case 1:
			p.ForeColor = Color.White;
			r.Text = t.m2;
			break;
		case 2:
			o.ForeColor = Color.White;
			r.Text = t.m4;
			break;
		case 3:
			n.ForeColor = Color.White;
			r.Text = t.m6;
			break;
		}
	}

	private void a()
	{
		switch (v)
		{
		case 0:
			u = new a(t, t.mz);
			u.ShowDialog();
			break;
		case 1:
			u = new a(t, t.m1);
			u.ShowDialog();
			break;
		case 2:
			u = new a(t, t.m3);
			u.ShowDialog();
			break;
		case 3:
			u = new a(t, t.m5);
			u.ShowDialog();
			break;
		}
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		if (A_1.KeyCode == Keys.Up && v > 0)
		{
			v--;
			b();
		}
		else if (A_1.KeyCode == Keys.Down && v < 3)
		{
			v++;
			b();
		}
		else if (A_1.KeyCode == Keys.Left)
		{
			t.e.Show();
			Hide();
			v = 0;
			b();
		}
		else if (A_1.KeyCode == Keys.Right)
		{
			t.a.Show();
			Hide();
			v = 0;
			b();
		}
		else if (A_1.KeyCode == Keys.Return)
		{
			a();
		}
		else if (A_1.KeyCode == Keys.Prior || A_1.KeyCode == Keys.Home)
		{
			v = 0;
			b();
		}
		else if (A_1.KeyCode == Keys.Next || A_1.KeyCode == Keys.End)
		{
			v = 3;
			b();
		}
		else if (A_1.KeyCode == Keys.F1)
		{
			t.ng();
		}
		else if (A_1.KeyCode == Keys.F5)
		{
			t.na();
		}
		else if (A_1.KeyCode == Keys.F7)
		{
			t.nd();
		}
		else if (A_1.KeyCode == Keys.F10)
		{
			t.l();
		}
		else if (A_1.KeyCode == Keys.Escape)
		{
			t.nf();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		A_1.Cancel = w;
	}

	private void c(object A_0, EventArgs A_1)
	{
		t.nc();
	}

	private void b(object A_0, EventArgs A_1)
	{
		s.ForeColor = Color.White;
	}

	private void a(object A_0, EventArgs A_1)
	{
		s.ForeColor = Color.FromArgb(224, 224, 224);
	}
}
