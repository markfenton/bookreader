using System;
using Gtk;
using System.IO;

public partial class MainWindow: Gtk.Window
{	
	
	FileStream bookFile;
	StreamReader bookReader;
	Int32 bookStreamPosition = 0; //stream position the top of the current page is at
	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	
	protected void populateTextArea()
	{
		String textline = bookReader.ReadToEnd();
		booktextview.Buffer.Text = textline;
	}
	
	protected void cleanupFileStreams()
	{
		bookReader.Close();
		bookFile.Close();
	}

	protected virtual void OnOpenFileActionActivated (object sender, System.EventArgs e)
	{
		FileChooserDialog fileDialog = new FileChooserDialog("Select Book",this,FileChooserAction.Open,
		                                                     "Cancel",ResponseType.Cancel,
		                            						"Open",ResponseType.Accept);

		if (fileDialog.Run() != (int)ResponseType.Accept) 
		{
			return; //nothing to do now!
		}
		
		try 
		{	
			bookFile = new FileStream(fileDialog.Filename, FileMode.Open, FileAccess.Read);
			bookReader = new StreamReader(bookFile);
		}	
		catch 
		{
			//error loading the file - display message and handle	
		}
		
		//get rid of file window
		fileDialog.Destroy();

		//now populate the text display
		populateTextArea();
	}
}