﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CBComponents
{
  public static partial class FormServices
  {
    /// <summary>
    /// The main form of the application
    /// </summary>
    public static IWin32Window MainWindow { get; set; }

    /// <summary>
    /// Image Links
    /// </summary>
    public static class Images
    {
      private static System.Drawing.Bitmap tableSelectImage = Properties.Resources.TableSelect;
      public static System.Drawing.Bitmap TableSelectImage
      {
        get { return Images.tableSelectImage; }
        set { if (value != null) Images.tableSelectImage = value; }
      }

      private static System.Drawing.Bitmap tableClearImage = Properties.Resources.TableClear;
      public static System.Drawing.Bitmap TableClearImage
      {
        get { return Images.tableClearImage; }
        set { if (value != null) Images.tableClearImage = value; }
      }
    }

    internal static DialogResult ShowFormDialog(Form form)
    {
      if (FormServices.MainWindow == null) return form.ShowDialog();
      else return form.ShowDialog(FormServices.MainWindow);
    }    

    internal static void ShowMessage(string Message)
    {
      if (FormServices.MainWindow == null) MessageBox.Show(Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
      else MessageBox.Show(FormServices.MainWindow, Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    
    internal static void ShowError(string ErrorMessage, bool IsWarning = false)
    {
      if (FormServices.MainWindow == null) MessageBox.Show(ErrorMessage, IsWarning ? "Warning" : "Error", MessageBoxButtons.OK, IsWarning ? MessageBoxIcon.Warning : MessageBoxIcon.Error);
      else MessageBox.Show(FormServices.MainWindow, ErrorMessage, IsWarning ? "Warning" : "Error", MessageBoxButtons.OK, IsWarning ? MessageBoxIcon.Warning : MessageBoxIcon.Error);
    }

    internal static void ShowError(Exception ex)
    {
      if (FormServices.MainWindow == null) MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
      else MessageBox.Show(FormServices.MainWindow, ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    internal static bool ShowWarning(string Message)
    {
      if (FormServices.MainWindow == null) return MessageBox.Show(Message, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
      else return MessageBox.Show(FormServices.MainWindow, Message, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
    }

    internal static bool ShowWarning(string Caption, string Message)
    {
      if (FormServices.MainWindow == null) return MessageBox.Show(Message, Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
      else return MessageBox.Show(FormServices.MainWindow, Message, Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
    }
    
  }
}