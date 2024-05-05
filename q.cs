using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class q : Form
{
	private u m_a;

	private bool b = true;

	private IContainer c;

	private Label d;

	private Panel e;

	private Panel f;

	private Panel g;

	private Panel h;

	private TextBox i;

	public q(u A_0, string A_1)
	{
		this.m_a = A_0;
		a();
		d.Text = A_1;
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		if (A_1.KeyCode == Keys.Escape)
		{
			this.m_a.m = "Cancel";
			b = false;
			Close();
		}
		else if (A_1.KeyCode == Keys.Return)
		{
			this.m_a.m = i.Text;
			b = false;
			Close();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		A_1.Cancel = b;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && c != null)
		{
			c.Dispose();
		}
		base.Dispose(disposing);
	}

	private void a()
	{
		d = new Label();
		e = new Panel();
		f = new Panel();
		g = new Panel();
		h = new Panel();
		i = new TextBox();
		SuspendLayout();
		d.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		d.ForeColor = Color.FromArgb(27, 35, 165);
		d.Location = new Point(26, 85);
		d.Name = "MyLabel";
		d.Size = new Size(310, 37);
		d.TabIndex = 7;
		d.Text = "Label";
		d.TextAlign = ContentAlignment.TopRight;
		e.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		e.BackColor = Color.FromArgb(27, 35, 165);
		e.Location = new Point(12, 22);
		e.Name = "Goriz1";
		e.Size = new Size(484, 3);
		e.TabIndex = 2;
		f.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		f.BackColor = Color.FromArgb(27, 35, 165);
		f.Location = new Point(12, 183);
		f.Name = "Goriz3";
		f.Size = new Size(484, 3);
		f.TabIndex = 3;
		g.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		g.BackColor = Color.FromArgb(27, 35, 165);
		g.Location = new Point(12, 22);
		g.Name = "Vert1";
		g.Size = new Size(3, 163);
		g.TabIndex = 5;
		h.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		h.BackColor = Color.FromArgb(27, 35, 165);
		h.Location = new Point(493, 22);
		h.Name = "Vert2";
		h.Size = new Size(3, 163);
		h.TabIndex = 6;
		i.BackColor = Color.FromArgb(190, 190, 190);
		i.BorderStyle = BorderStyle.FixedSingle;
		i.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		i.ForeColor = Color.White;
		i.Location = new Point(340, 85);
		i.Name = "PassVvod";
		i.PasswordChar = '*';
		i.ShortcutsEnabled = false;
		i.Size = new Size(130, 41);
		i.TabIndex = 8;
		i.KeyDown += a;
		base.AutoScaleDimensions = new SizeF(19f, 37f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.White;
		base.ClientSize = new Size(508, 208);
		base.Controls.Add(i);
		base.Controls.Add(d);
		base.Controls.Add(h);
		base.Controls.Add(g);
		base.Controls.Add(f);
		base.Controls.Add(e);
		Font = new Font("Arial", 24f, FontStyle.Bold, GraphicsUnit.Point, 204);
		ForeColor = Color.FromArgb(190, 190, 190);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(10, 9, 10, 9);
		base.Name = "Boot_Security_PassVvod_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Boot_Security_PassVvod_Form";
		base.FormClosing += a;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
