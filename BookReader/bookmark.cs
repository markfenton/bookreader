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

namespace BookReader
{
	
	
	public class bookmark
	{
		public Int32 filePosition;
		public String fileTitle;
		public Int32 fileHash; //since the title might change if they move the file and we want to be clever!
		
	}
	
	
}
