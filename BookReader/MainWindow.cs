//  
//  Copyright (C) 2009 Mark Fenton
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
// 
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
// 

using System;
using Gtk;
using System.IO;
//using System.Xml;
using BookReader;

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
		CleanupFileStreams();
		Application.Quit ();
		a.RetVal = true;
	}
	
	protected void PopulateTextArea()
	{
		String textline = bookReader.ReadToEnd();
		booktextview.Buffer.Text = textline;
	}
	
	protected void CleanupFileStreams()
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
		PopulateTextArea();
	}

	protected virtual void OnBookmarkPositionActionActivated (object sender, System.EventArgs e)
	{
		Int32 hashcode = bookFile.GetHashCode();
				
		bookmark currentBookmark = new bookmark();
		
		currentBookmark.fileHash = hashcode;
		currentBookmark.fileTitle = "Not implemented";
		currentBookmark.filePosition = bookStreamPosition;
		
		//add new bookmark to list
		
		//write bookmark to file
	}

}