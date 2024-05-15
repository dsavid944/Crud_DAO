using System;
using System.Drawing;
using System.Windows.Forms;

public class InputBox : Form
{
    private TextBox inputTextBox;
    private Button okButton;
    private Button cancelButton;
    private Label promptLabel;

    public InputBox(string title, string prompt)
    {
        this.Text = title;
        this.ClientSize = new Size(300, 120);

        promptLabel = new Label();
        promptLabel.Text = prompt;
        promptLabel.Location = new Point(10, 10);
        promptLabel.Size = new Size(280, 20);
        this.Controls.Add(promptLabel);

        inputTextBox = new TextBox();
        inputTextBox.Location = new Point(10, 40);
        inputTextBox.Size = new Size(280, 20);
        this.Controls.Add(inputTextBox);

        okButton = new Button();
        okButton.Text = "OK";
        okButton.DialogResult = DialogResult.OK;
        okButton.Location = new Point(135, 70);
        okButton.Size = new Size(75, 25);
        this.Controls.Add(okButton);

        cancelButton = new Button();
        cancelButton.Text = "Cancel";
        cancelButton.DialogResult = DialogResult.Cancel;
        cancelButton.Location = new Point(215, 70);
        cancelButton.Size = new Size(75, 25);
        this.Controls.Add(cancelButton);

        this.AcceptButton = okButton;
        this.CancelButton = cancelButton;
    }

    public string InputText
    {
        get { return inputTextBox.Text; }
    }

    public static string Show(string title, string prompt)
    {
        using (InputBox inputBox = new InputBox(title, prompt))
        {
            if (inputBox.ShowDialog() == DialogResult.OK)
            {
                return inputBox.InputText;
            }
            return null;
        }
    }
}
