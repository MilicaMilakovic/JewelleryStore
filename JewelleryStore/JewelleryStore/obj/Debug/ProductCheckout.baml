   M S B A M L   `   `   `  ����I  EJewelleryStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:JewelleryStoreJewelleryStore  5      $    JewelleryStore.ProductCheckout   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:JewelleryStore     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5      � 
�������$��3,3,3,3q�6   +  %MaterialDesignThemes.Wpf.ShadowAssist    ShadowDepth$  Depth4=�6/    � ColumnDefinitions 5   
   �� 5      $	��92* �6   �� 5      $
��111* �6   �� 5      $
��171* �6   �� 5      $	��86* �6   �� 5      $	��37* �6   .+�5   
   �� -   5         ��Name$ productPhoto��5      $��/images/1.jpg��6'   $��0,3,0,0q�6>   $��88��6O   $	��Top=�6[   �� 5   
   -   5         ��Name$ productName��5   K   $��WrapWithOverflow=�6    �� TextAlignment$ Center=�64   $��1��6`   $��ProductName��6p   $��Center=�6�   $��67��6�   $��
10,24,10,3q�6�   �� 5   
   -   5         ��Name$ removeOneBtn��5      $��2��69   $��-��6I   $
��Auto��6V   $��10,29,117,35q�6d   �� 5   
   -   5        $ 	addOneBtn��5      $��2��63   $��+��6C   $
��Auto��6P   $��117,29,10,35q�6^    J� RenderTransformOrigin$ 0.5,0.5&�6t   z�5      V� 5      .~�5      ��  �� ScaleX$ -1Q�6%   �� 5      �� 5      T� 5      5      5       �� 5!   
   -   5         ��Name$ quantityLabel��5!      $��2��6'   $��1��67   $��Center=�6C   $��Center=�6^   $��Center=�6�   $��54,29,53,35q�6�   $��30��6�   �� 5"   
   -   5        $ price��5"      $��3��6   $��
BAM Cijena��6/   $��Center=�6D   $��Center=�6_   $��DemiBold"�6|   $��29��6�   $��	2,33,0,32q�6�   $��84��6�   $ 0.542,0.833&�6�   �� 5#   
   -   5        $ 
removeItem��5#      $��4��5%      $��Center=�5&      $
��Auto��5'      $��	5,33,6,35q�5(      $��26��5)       &  "MaterialDesignIconForegroundButton#��[  5*      ���#E2EEED{�5,      �� *DataContext.ControlsEnabled+	 �� RelativeSource	 �� *FindAncestor+
 �� AncestorType$
 WindowL�.��5-      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�5.      5/      �� 52   
   $��5��6   $��0��6(   ���#F8E2E7$��Bottom=�6J   $  Depth5=�6f   $��1��6�   $��0q�6�   53      54      