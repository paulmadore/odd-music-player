//
// ParsedPlaylist.cs
//
// Authors:
//   Aaron Bockover <abockover@novell.com>
//   Bertrand Lorentz <bertrand.lorentz@gmail.com>
//   Andrés G. Aragoneses <knocte@gmail.com>
//
// Copyright (C) 2007 Novell, Inc.
// Copyright (C) 2014 Andrés G. Aragoneses
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System.Collections.Generic;

namespace Banshee.Playlists.Formats
{
    public class ParsedPlaylist
    {
        internal ParsedPlaylist (string title, List<PlaylistElement> elements)
        {
            Title = title;
            Elements = elements;
        }

        public List<PlaylistElement> Elements { get; private set; }
        public string Title { get; private set; }
    }
}
