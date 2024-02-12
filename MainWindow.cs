using Microsoft.Extensions.Configuration;
using System.Windows.Forms;

namespace schedulo;

public partial class MainWindow : Form
{
    private readonly IConfiguration _configuration;
    private CreateTaskButton createTaskButton;
    public MainWindow(IConfiguration configuration)
    {
        _configuration = configuration;
        InitializeComponent();
        createTaskButton = new CreateTaskButton(configuration, "Создать задачу");
        Controls.Add(createTaskButton);
        createPanel.Controls.Add(createTaskButton);
    }
    private void InitializeComponent()
    {
        createPanel = new Panel();
        SuspendLayout();
        // 
        // createPanel
        // 
        createPanel.Location = new Point(12, 12);
        createPanel.Name = "createPanel";
        createPanel.Size = new Size(127, 44);
        createPanel.TabIndex = 0;
        // 
        // MainWindow
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(822, 398);
        Controls.Add(createPanel);
        Name = "MainWindow";
        Text = "schedulo";
        ResumeLayout(false);
    }

    private Panel createPanel;
}