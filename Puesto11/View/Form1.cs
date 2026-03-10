using FontAwesome.Sharp;
using Microsoft.Data.SqlClient;
using System.Runtime.InteropServices;
using Common;
using Common.Cache;
namespace Puesto11;



public partial class Form1 : Form
{
    //crear metodo para cargar datos:))
    //fields

    private IconButton currenBtn;
    private Panel leftBorderBtn;
    private Form currentChildForm;


    public Form1()
    {

        InitializeComponent();
        mostrarImagen();
        leftBorderBtn = new Panel();
        leftBorderBtn.Size = new Size(10, 87);   //7, 60
        panelMenu.Controls.Add(leftBorderBtn);
        //para la pantalla 
        this.Text = String.Empty;
        this.ControlBox = false;
        this.DoubleBuffered = true;
        this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        lbl_Correo.Text = ActiveUser.correo;
        lbl_Nombre.Text = ActiveUser.nombre + " " + ActiveUser.apellido;



    }
    private struct RGBcolor()
    {
        public static Color color1 = Color.FromArgb(172, 126, 241);
        public static Color color = Color.FromArgb(249, 118, 176);
        public static Color color3 = Color.FromArgb(253, 138, 114);
        public static Color color4 = Color.FromArgb(95, 77, 221);
        public static Color color5 = Color.FromArgb(249, 88, 155);
        public static Color color6 = Color.FromArgb(24, 161, 251);
    }

    private void ActivaButton(object senderBtn, Color color)
    {
        if (senderBtn != null)
        {
            DisableButton();
            //boton
            currenBtn = (IconButton)senderBtn;
            currenBtn.BackColor = Color.FromArgb(58, 73, 118);
            currenBtn.ForeColor = color;
            currenBtn.TextAlign = ContentAlignment.MiddleCenter;
            currenBtn.IconColor = color;
            currenBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            currenBtn.ImageAlign = ContentAlignment.MiddleRight;
            //Border boton izquierda
            leftBorderBtn.BackColor = color;
            leftBorderBtn.Location = new Point(0, currenBtn.Location.Y);
            leftBorderBtn.Visible = true;
            leftBorderBtn.BringToFront();
            //Icon De Home
            icono_inicio.IconChar = currenBtn.IconChar;
            icono_inicio.IconColor = color;

        }
    }

    public void mostrarImagen()
    {
        if (ActiveUser.imageData != null && ActiveUser.imageData.Length > 0)
        {
            using (var ms = new MemoryStream(ActiveUser.imageData))
            {
                rjCircle1.Image = Image.FromStream(ms); // Carga la imagen desde los bytes
                rjCircle1.SizeMode = PictureBoxSizeMode.StretchImage; // Ajusta el tamaño para que ocupe el espacio

                // Crear una máscara circular para la imagen
                System.Drawing.Drawing2D.GraphicsPath circularPath = new System.Drawing.Drawing2D.GraphicsPath();
                circularPath.AddEllipse(0, 0, rjCircle1.Width, rjCircle1.Height);
                rjCircle1.Region = new Region(circularPath);
            }
        }
        else
        {
            // Si no hay imagen, muestra una predeterminada o deja el control vacío
            rjCircle1.Image = null; // O puedes asignar una imagen predeterminada aquí
            rjCircle1.Region = null; // Limpia la región por si ya se aplicó antes
        }
    }

    private void DisableButton()
    {
        if (currenBtn != null)
        {

            currenBtn.BackColor = Color.FromArgb(58, 73, 118);
            currenBtn.ForeColor = Color.White;
            currenBtn.TextAlign = ContentAlignment.MiddleLeft;
            currenBtn.IconColor = Color.White;
            currenBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            currenBtn.ImageAlign = ContentAlignment.MiddleLeft;
        }

    }

    private void openChilForm(Form childForm)
    {

        if (childForm != null)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_escritorio.Controls.Add(childForm);
            pnl_escritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_Home.Text = childForm.Text;
        }

    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void iconButton1_Click(object sender, EventArgs e)
    {
        ActivaButton(sender, RGBcolor.color1);

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btn_orden_Click(object sender, EventArgs e)
    {
        ActivaButton(sender, RGBcolor.color3);

    }

    private void btn_productos_Click(object sender, EventArgs e)
    {
        ActivaButton(sender, RGBcolor.color);

    }

    private void btn_cliente_Click(object sender, EventArgs e)
    {
        ActivaButton(sender, RGBcolor.color4);


    }

    private void btn_ganacias_Click(object sender, EventArgs e)
    {
        ActivaButton(sender, RGBcolor.color5);

    }

    private void btn_deseos_Click(object sender, EventArgs e)
    {
        ActivaButton(sender, RGBcolor.color6);
        openChilForm(new FormularioPerfilEdit());
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {


        Reset();
    }
    private void Reset()
    {
        DisableButton();
        leftBorderBtn.Visible = false;
        icono_inicio.IconChar = IconChar.House;
        icono_inicio.IconColor = Color.MediumPurple;
        lbl_Home.Text = "Home";


    }







    private void lbl_home_Click(object sender, EventArgs e)
    {

    }

    private void lbl_Home_Click_1(object sender, EventArgs e)
    {

    }
    //evento para manejar bien la pantalla :)
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

    private void panel_titulo_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    private void cerrar_Click(object sender, EventArgs e)
    {

    }

    private void picture_Cerrar_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("¿Deseas SALIR?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            Application.Exit();
        }
        else if (result == DialogResult.No)
        {

        }
    }

    private void picture_Minimizar_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void panel1_Paint_1(object sender, PaintEventArgs e)
    {

    }

    private void Fecha_Hora_Tick(object sender, EventArgs e)
    {
        lbl_Hora.Text = DateTime.Now.ToString("HH:mm:ss");
        lbl_Fecha.Text = DateTime.Now.ToString("dddd MMMM yyy");
    }

    private void pictureBox1_Click_1(object sender, EventArgs e)
    {

    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {

    }

    private void lbl_hours_Click(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox5_Click(object sender, EventArgs e)
    {

    }

    private void btn_Sari_Click(object sender, EventArgs e)
    {
    }

    private void iconButton1_Click_1(object sender, EventArgs e)
    {
    }

    private void iconButton2_Click(object sender, EventArgs e)
    {
    }

    private void cargarDatos()
    {

    }
    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void panel_titulo_Paint(object sender, PaintEventArgs e)
    {

    }

    private void pnl_escritorio_Paint(object sender, PaintEventArgs e)
    {

    }

    private void chart1_Click(object sender, EventArgs e)
    {

    }

    private void chart2_Click(object sender, EventArgs e)
    {

    }

    private void pnl_escritorio_Paint_1(object sender, PaintEventArgs e)
    {

    }

    private void iconButton4_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("¿Deseas SALIR?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            this.Close();
            FormInicio er = new FormInicio();
            er.Show();
        }
        else if (result == DialogResult.No)
        {

        }
    }



    private void iconButton3_Click(object sender, EventArgs e)
    {

    }

    private void iconButton1_Click_2(object sender, EventArgs e)
    {
        ActivaButton(sender, RGBcolor.color5);
        openChilForm(new AgendarCitas());
    }

    private void iconButton2_Click_1(object sender, EventArgs e)
    {
        ActivaButton(sender, RGBcolor.color1);
        openChilForm(new Catalogo());

    }

    private void pictureBox2_Click_1(object sender, EventArgs e)
    {

    }

    private void iconButton3_Click_1(object sender, EventArgs e)
    {
        ActivaButton(sender, RGBcolor.color5);
    }


    private void lbl_Nombre_Click(object sender, EventArgs e)
    {

    }

    private void iconPictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void iconButton4_Click_1(object sender, EventArgs e)
    {

        DialogResult result = MessageBox.Show("¿Deseas SALIR?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            this.Close();
            FormInicio er = new FormInicio();
            er.Show();
        }
        else if (result == DialogResult.No)
        {

        }
    }

    private void pictureBox2_Click_2(object sender, EventArgs e)
    {

    }
}
