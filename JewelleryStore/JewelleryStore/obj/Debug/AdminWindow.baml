   M S B A M L   `   `   `  ����I  EJewelleryStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:JewelleryStoreJewelleryStore  5   	        JewelleryStore.AdminWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   (localclr-namespace:JewelleryStore  5   	     � 
ResizeMode$  NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � Title$ Admin��5   	   $	��600��6   $	��900��6$    � 	Resources 5       �� Source�� 5   
   $ /Resources/Styles.xaml?�6   %    .��5      �    MaterialDesignPaper#���   6    � ColumnDefinitions 5   
   �� 5      $
��160* �6   �� 5      $
��527* �6   �� 5      $
��207* �6    � RowDefinitions 5   
   �� 5      $	��48* �6   �� 5      $	��68* �6   �� 5      $	��71* �6   �� 5      $
��213* �6   �� 5      $
��140* �6   �� 5      $	��31* �6   .+�5"   
   �� $��0��6   $��6��6$    J� Opacity$	 0.3Q�65     PrimaryHueLightBrush#���  6C   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth2=�5#      	   ShadowEdges$	 Right=�5$      �� 5'   
   -   5        
 ��Name$
 ProductsBtn��5'      $��3��6&    ! MaterialDesignFlatLightButton#��[ 5)        Products#���  5*       �� 	IsDefault . #���  5,      $	��Top=�5-      $��50��5/      $��0,29,0,0q�6   �� 50   
   -   5        $
 StaffBtn��50      $��3��6#   #��[ 52       	 Staff#���  53      #���  54      $	��Top=�55      $��50��57      $��0,84,0,0q�6   �� 58   
   -   5        $
 StatBtn��58      $��3��6"   #��[ 5:        
Statistics#���  5;      #���  5<      $	��Top=�5=      $��50��5?      $��	0,139,0,0q�6   �� 5B   
   $��1��5C      $��Right=�6    �� Orientation$ 
Horizontal=�5D      $��4q�5E      .+�5F      	� -   5         � Cursor$
 Hand��5F   <      MaterialDesignTabRadioButton#��[ 5G      $��4q�5H      
 � Tag$ Theme1��5I        Blue#���  5J      	� 5K      -   5        $
 Hand��5K   <   #��[ 5L      $��4q�5M      $ Theme2��5N       d� 	IsChecked$ FalseY�6     Red#���  5O      	� 5P      -   5        $
 Hand��5P   <   #��[ 5Q      $��4q�5R      $ FalseY�5S      $ Theme3��6#    		 Brown#��� 	 5T      5U      �� 5Z   
   $��/images/logo.png��6   $��0��6*   $
��10,0q�6:   $��1��6J    J� RenderTransformOrigin$ 0.507,0.544&�6^   �� 5[   
   -   5         ��Name$ 	pageLabel��5[      $��1��5\      $��15(�6    $��10,10,435,10q�5]      $
��Bold"�5^      ���#36BEB3$��Center=�5_      $��28��6+    � 5d   
   -   5          �Name$ myFrame��5d   C   #���   6     � NavigationUIVisibility$ Hidden=�6T   $��1��6t   $��1��6�   $��4��6�   $��2��6�   5f      #  MaterialDesignThemes.Wpf.Chip  5i   
   $��2��6   $��Admin��5j         Icon$ A��5k      $��34,8,0,8q�6   $	��116��6(   $
��Auto��64   d� 5n   
   -	   5        $��2��5n       $
  MaterialDesignActionToggleButton#��[
 5o      $��SR��5p      $��11(�6    $��Center=�5q      1  +MaterialDesignThemes.Wpf.ToggleButtonAssist   	OnContent$ EN��5t       �� Left$	 291��6B   
 �� Top$	 321��6T   $��32��6e   $��32��6q   $ Depth1=�5u      $��0,0,15,8q�5v      $��Bottom=�6#   $��Right=�6>   �� 5w   
   -
   5        $��4��5x      $��Bottom=�6     MaterialDesignIconButton#��[ 5y      $��0,0,56,0q�5z      $��48��6#   $ 	0.493,0.5&�6.   $��Right=�6P   .��5{      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Logout=�5|      5}      5      5�      