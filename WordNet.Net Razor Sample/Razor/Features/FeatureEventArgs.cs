/*
 * This file is a part of the Razor Framework.
 * 
 * Copyright (C) 2003 Mark (Code6) Belles 
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 * 
 * */

using System;

namespace Razor.Features
{
	/// <summary>
	/// Summary description for FeatureEventArgs.
	/// </summary>
	public class FeatureEventArgs : System.EventArgs 
	{
		private Feature _feature;

		public FeatureEventArgs(Feature feature)
		{
			_feature = feature;
		}

		public Feature Feature
		{
			get
			{
				return _feature;
			}
			set
			{
				_feature = value;
			}
		}
	}

	public delegate void FeatureEventHandler(object sender, FeatureEventArgs e);
}
