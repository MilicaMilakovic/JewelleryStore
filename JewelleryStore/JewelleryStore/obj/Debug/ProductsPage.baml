   M S B A M L   `   `   `  ����I  EJewelleryStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:JewelleryStoreJewelleryStore  5      !    JewelleryStore.ProductsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      (localclr-namespace:JewelleryStore  5        N� Title$  ProductsPage��5
       � 	Resources 5       �� Source�� 5   
   $ /Resources/Styles.xaml?�6   %    .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��68* �6   �� 5      $	��71* �6   �� 5      $
��213* �6   �� 5      $
��140* �6   �� 5      $	��31* �6    � ColumnDefinitions 5   
   �� 5      $
��527* �6   �� 5      $
��207* �6   .+�5    
   �� -   5        $��0��5       $��0��6!    #  MaterialDesignRaisedLightButton#��[  5!        Add#���  5"      
�������$��
10,7,386,2q�5$      $��40��6)   �� 5&   
   -   5         ��Name$ editBtn��5&      $��0��5'      $��0��6!   $��172,7,224,2q�5(       " MaterialDesignPaperLightButton#��[ 5)        Edit#���  5*      ���#80CBC4{�.  $��40��5,   #   �� 5.   
   -   5        $ 	deleteBtn��5.      $��0��50      $��0��6"   $��
336,7,61,2q�6/   #��[ 51       
 Delete#���  52      ���#80CBC4{�.  $��40��55      �� 57   
   -   5         ��Name$ SearchField��58      $��0��57      $��1��6    % !MaterialDesignFloatingHintTextBox#��[ 59      $��Center=�5:      .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton . $��
0,14,10,12q�5;   G   $��42��6[   .��6h   )  #MaterialDesignThemes.Wpf.HintAssist   Hint 5=      �� 5?      	 �� Orientation$	 
Horizontal=�6!   $��-2 0 0 0q�6<   .+�5@      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 Search=�68   �� 5A       
 Search#���  5B   &   5C      .��5E   2   5F      �� 5I   
   -   5         ��Name$ scrollBarViewer��5I      $��10q�60   $��0��6<   $��2��6L   $��1��6`   $��4��6m   .��5J      � -   5         �Name$ products��5J      5K      5L      5M      