   M S B A M L   `   `   `  ????J  FABC-Song-Layout, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ABC_Song_LayoutABC_Song_Layout  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5	   	        ABC_Song_Layout.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ABC_Song_Layout     5   	   6sys&clr-namespace:System;assembly=mscorlib     5	   	   _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   -   5          ? Title$  ABC Song Layout??5   	   $	??700??6!   $
??1000??6.      MaterialDesignBody#???   5   	     MaterialDesignPaper#???  5   	   $??Medium"?5   	   $??14(?5   	    ? WindowStartupLocation$ CenterScreen=?5   	   ??5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension   ? 	Resources 5        	layout-cn ?? 	UriSource  	layout-en  ButtonWidth??%?   &	       &	 .     &	 \     ?? 5   
   $ Resources/abc-cn.png??6(   ?? 5   
   $ Resources/abc-en.png??6(   X?5   
   100Q?5      5      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??80 ?6   6*   ?? 5      $
??auto ?6   6,   ?? 5       $??80 ?6   6*   .+?5#   
   ?? $??Stretch=?6   $??0??61   .+?5$      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=?62   $??16q?5%   2   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowEdges$ Bottom,Right=?5&   2   .??5'      ]? .+?5(      '  !MaterialDesignThemes.Wpf.PopupBox  $??Right=?63      PlacementMode$ BottomAndAlignRightEdges=?6O      PopupContent. 5)      ?? .@?5*      ?? $??Apply??63   ?? 5+      $??Restore Default??63   5,      5-      ?? 5.      	 ?? Orientation$	 
Horizontal=?6&   .+?5/      d?  ' #MaterialDesignHamburgerToggleButton#??[ 6.   ?? 50      $??Center=?6(   $??Center=?6G   $??16 0 0 0q?6i   $0??*Welcom to Use the ABC Song Keyboard Layout??6?   51      52      53      55      ? 56   
   $??1??6   
 ? ColumnDefinitions
 57      ?? 58      $
??135* ?6#   62   ?? 59      $
??135* ?6#   62   .+?5<      #  MaterialDesignThemes.Wpf.Card  $??0??6"   $??20q?63   .??5=      ?  5?      ?? 5A      $
??auto ?6/   ?? 5B      $	??100 ?6/   ?? 5C      $	??100 ?6/   .+?5E      ?? $??20q?6   #??[ 6-   $??0??6Q   $
??auto??6b   $
??auto??6u   $??Uniform=?6?   ?? 5G      $??1??6&   $??20q?5H   &   .+?5I      ?? $
??Wrap=?6+   $??Center=?5J   +   $;??5This layout is based on the popular ABC song in China??5K   +   5L      ?? 5M      $??Right=?6&   $??2??5N   &   $	 
Horizontal=?5O   &   $??20q?5P   &   .+?5Q      %  MaterialDesignThemes.Wpf.Badged  -   5          Name$ badged1??5Q   0      BadgeColorZoneMode$ SecondaryMid=?5R   0   .??5S      ?? -   5         ??Name$ SelectButton1??5S   %   $??Select??5T   %   {?5U   %   ?? *DataContext.ControlsEnabled+ ?? RelativeSource ?? *FindAncestor+ ?? AncestorType$ WindowL?5V   %   5W      5X      5Y      5Z        5[      $??1??6"   $??20q?5\   "   .??5]      ?  5_      ?? 5a      $
??auto ?6/   ?? 5b      $	??100 ?6/   ?? 5c      $	??100 ?6/   .+?5e      ?? $??20q?6   #??[ 5f      $??0??5g      $
??auto??5h      $
??auto??5i      $??Uniform=?5j      ?? 5l      $??1??6&   $??20q?5m   &   .+?5n      ?? $
??Wrap=?6+   $??Center=?5o   +   $D??>This layout is based on the popular ABC song in North American??5p   +   5q      ?? 5r      $??Right=?6&   $??2??5s   &   $	 
Horizontal=?5t   &   $??20q?5u   &   .+?5v        -   5        $ badged2??5v   0   $ SecondaryMid=?5x   0      Badge 5w   0   0  *MaterialDesignThemes.Wpf.PackIconExtension  *CheckOutline+.??5y      ?? -   5        $ SelectButton2??5y   %   $??Select??5z   %   {?5{   %   ?? *DataContext.ControlsEnabled+ ?? *FindAncestor+$ WindowL?5|   %   5}      5      5?      5?      5?      ?? 5?   
   $??2??6   $	 
Horizontal=?6"   $??Center=?6;   .+?5?      ?? -   5        $??0, 0, 20, 0q?5?        MaterialDesignRaisedButton#??[ 5?      #??[ 5?      $??Apply??5?      {?5?      ?? *DataContext.ControlsEnabled+ ?? *FindAncestor+$ WindowL?5?      ?? 5?      -   5        $??0, 0, 20, 0q?5?      #??[ 5?      $
??auto??5?      $??Reset to Default??5?      {?5?      ?? *DataContext.ControlsEnabled+ ?? *FindAncestor+$ WindowL?5?      5?      5?      5?      