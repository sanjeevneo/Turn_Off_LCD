// Decompiled with JetBrains decompiler
// Type: Turn_Off_LCD.Program
// Assembly: Turn Off LCD, Version=1.2.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 3178956E-493C-4664-8DBE-4FB2C22BC1C1
// Assembly location: C:\Users\SESA425511.APA\Downloads\Turn Off LCD.exe

using System;

namespace Turn_Off_LCD
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Console.Write("\n\t\t\t    SanjeevRules's 'Turn Off LCD'\n");
      Console.Write("\t\t\t\t    Version 1.21\n\n");
      Console.Write("\n\n\t\t\t\t\t\t\t2008 (C) SanjeevRules");
      Console.Write("\n\t\t\t\t\t\t\twww.sanjeevneo.com\n\nIcon (C) 2008 Microsoft Corporation.\n");
      new PowerBoard().TurnOffLCD();
      Console.Write("Press enter key to continue...");
    }
  }
}
