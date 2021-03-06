﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FluentConsole.Library.ConsoleWrapper;

namespace FluentConsole.Library
{
    /// <summary>
    /// Fluent interface for console applications
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream.
        /// </summary>
        /// <param name="value">The value to write.</param>
        /// <param name="lineBreaks">The number of *additional* line breaks to include after the specified value.</param>
        public static void WriteLine(this object value, int lineBreaks = 0)
        {
            ConsoleWrapper.WriteLine(value);

            for (var i = 0; i < lineBreaks; i++)
                NewLine();
        }

        /// <summary>
        /// Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream.
        /// </summary>
        /// <param name="value">The value to write.</param>
        /// <param name="foreColor">The foreground color of the text displayed.</param>
        /// <param name="lineBreaks">The number of *additional* line breaks to include after the specified value.</param>
        public static void WriteLine(this object value, ConsoleColor foreColor, int lineBreaks = 0)
        {
            ForegroundColor = foreColor;
            ConsoleWrapper.WriteLine(value);
            ResetColor();

            for (var i = 0; i < lineBreaks; i++)
                NewLine();
        }

        /// <summary>
        /// Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream.
        /// </summary>
        /// <param name="value">The value to write.</param>
        /// <param name="foreColor">The foreground color of the text displayed.</param>
        /// <param name="backColor">The background color of the text displayed.</param>
        /// <param name="lineBreaks">The number of *additional* line breaks to include after the specified value.</param>
        public static void WriteLine(this object value, ConsoleColor foreColor, ConsoleColor backColor, int lineBreaks = 0)
        {
            ForegroundColor = foreColor;
            BackgroundColor = backColor;
            ConsoleWrapper.WriteLine(value);
            ResetColor();

            for (var i = 0; i < lineBreaks; i++)
                NewLine();
        }

        /// <summary>
        /// Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream.
        /// </summary>
        /// <param name="value">The value to write.</param>
        /// <param name="options">A WriteOptions object, indicating desired display options for text displayed.</param>
        public static void WriteLine(this object value, WriteOptions options)
        {
            WriteLine(value, options.ForeColor, options.BackColor, options.LineBreaks);
        }

        /// <summary>
        /// Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream.
        /// </summary>
        /// <param name="value">The value to write.</param>
        /// <param name="lineBreaks">The number of *additional* line breaks to include after the specified value.</param>
        /// <returns>The key entered while waiting.</returns>
        public static ConsoleKeyInfo WriteLineWait(this object value, int lineBreaks = 0)
        {
            ConsoleWrapper.WriteLine(value);

            for (var i = 0; i < lineBreaks; i++)
                NewLine();

            var key = ReadKey();
            NewLine();
            return key;
        }

        /// <summary>
        /// Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream.
        /// </summary>
        /// <param name="value">The value to write.</param>
        /// <param name="foreColor">The foreground color of the text displayed.</param>
        /// <param name="lineBreaks">The number of *additional* line breaks to include after the specified value.</param>
        /// <returns>The key entered while waiting.</returns>
        public static ConsoleKeyInfo WriteLineWait(this object value, ConsoleColor foreColor, int lineBreaks = 0)
        {
            ForegroundColor = foreColor;
            ConsoleWrapper.WriteLine(value);
            ResetColor();

            for (var i = 0; i < lineBreaks; i++)
                NewLine();

            var key = ReadKey();
            NewLine();
            return key;
        }

        /// <summary>
        /// Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream.
        /// </summary>
        /// <param name="value">The value to write.</param>
        /// <param name="foreColor">The foreground color of the text displayed.</param>
        /// <param name="backColor">The background color of the text displayed.</param>
        /// <param name="lineBreaks">The number of *additional* line breaks to include after the specified value.</param>
        /// <returns>The key entered while waiting.</returns>
        public static ConsoleKeyInfo WriteLineWait(this object value, ConsoleColor foreColor, ConsoleColor backColor, int lineBreaks = 0)
        {
            ForegroundColor = foreColor;
            BackgroundColor = backColor;
            ConsoleWrapper.WriteLine(value);
            ResetColor();

            for (var i = 0; i < lineBreaks; i++)
                NewLine();

            var key = ReadKey();
            NewLine();
            return key;
        }

        /// <summary>
        /// Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream.
        /// </summary>
        /// <param name="value">The value to write.</param>
        /// <param name="options">A WriteOptions object, indicating desired display options for text displayed.</param>
        /// <returns>The key entered while waiting.</returns>
        public static ConsoleKeyInfo WriteLineWait(this object value, WriteOptions options)
        {
            return WriteLineWait(value, options.ForeColor, options.BackColor, options.LineBreaks);
        }
    }
}
