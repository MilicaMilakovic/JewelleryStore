   M S B A M L   `   `   `  ����I  EJewelleryStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:JewelleryStoreJewelleryStore  5   	       JewelleryStore.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   :d2http://schemas.microsoft.com/expression/blend/2008  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   (localclr-namespace:JewelleryStore  5   	     � Title$  Login��5	   	   $	��400��6   $	��600��6$    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5         AdminButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers	 P� Property
 P� Value��%�  &	        �� 5   
   " ��6$   .�5      ��  � �� �#2B2B2B6+   �� 5       � ��$ Regular"�6+   �� 5       � ��$ 11(�6)   �� 5       � ��
 ���� 6+   �� 5       � ��
 ���� 6,   �� 5       �@�Cursor$
 Hand��6'   �� 5       � ��$ 27��6'   �� 5       � ��$	 166��6&   �� 5       � ��$ Center=�6;   �� 5       � �� 5      �� 5      " ��6&   .R�5      � #��z��6   .+�5      �� 5      5      5!       5"      P� 5#      	 �@J�IsMouseOver
 . . �5$      ��  � �� �#80CBC463   �� 5%       � ��$
 Bold"�63   �� 5&       � ��
 ���� 63   �� 5'       � ��
 ���� 64   5(      P� 5*      	 �@J�IsMouseCaptured
 . . �5+      ��  � �� �#80CBC463   �� 5,       � ��$
 Bold"�63   �� 5-       � ��
 ���� 63   �� 5.       � ��
 ���� 64   5/      51      52      .��53      �  � RowDefinitions 54   
   �� 55      $	��10* �6   �� 56      $
��359* �6   .+�58   
   �� $��2��6   .+�59      �� $��/images/img.jpg��6   $	��406��6-   $	��624��6:   
 �� Top$	 -12��6F    �� Left$	 -13��6W   �� 5:      $	��303��6   $	��369��6$   
�������+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth4=�5<         ShadowEdges$ Right=�5=      '  !MaterialDesignThemes.Wpf.PackIcon  5?         Kind$ AccountOutline=�6&   ���#4E4E4E$ 61��6Q   $ 99��6b   $��25��6r   $��22��6~   �� 5@      -   5         ��Name$ username��5@        Username)  #MaterialDesignThemes.Wpf.HintAssist   Hint# �  6(   $	��154��6d   $��36��6p   $��Center=�6|   $
��Left=�6�   $ 88��6�   $ 94��6�     5A      $ Password=�6&   ���#4E4E4E$ 61��6K   $	 169��6\   $��25��6m   $��22��6y   G� 5B      -   5         G�Name$ password��5B        Password# �  6,   $	��154��6h   $��30��6t   $��Center=�6�   $
��Left=�6�   $ 88��6�   $	 169��6�   �� 5C      -   5         ��Name$ loginBtn��5E       # MaterialDesignRaisedLightButton#��[ 5D      $	��107��5E   1   $��30��6=   
�������$
��Bold"�5F   $   $	 105��66   $	 242��6H    	 Login#���  6Y   �� 5G      $��/images/logo.png��6   $��40��6.   $	��283��6:   $ 10��6F   $ 10��6W   �� 5I      -   5        $ 94��5J      $	 294��6&   #��[  5K        
AdminLogin#���  5L      $��Center=�5M      $��Center=�5N      $��20��67   $	��138��6C   d� 5]      -   5         $  MaterialDesignActionToggleButton#��[ 5^      $��SR��5_      $��11(�6    $��Center=�5`      $��Center=�5a      1  +MaterialDesignThemes.Wpf.ToggleButtonAssist   	OnContent$ EN��5d      $ 10��6B   $	 320��6S   $��30��6d   $��30��6p   $ Depth2=�5e      .  (MaterialDesignThemes.Wpf.ColorZoneAssist   
Background
 �����5f      5g      5h      5i      