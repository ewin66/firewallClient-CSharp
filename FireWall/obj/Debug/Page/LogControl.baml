   M S B A M L   `   `   `  ����C  ?FireWall, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:FireWallFireWall  5
          FireWall.LogControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      a ]DevExpress.Xpf.Core.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  5      Cdxsch7http://schemas.devexpress.com/winfx/2008/xaml/scheduler  5      Adxca6http://schemas.devexpress.com/winfx/2008/xaml/carousel  5      c _DevExpress.Xpf.Gauges.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a?dxga4http://schemas.devexpress.com/winfx/2008/xaml/gauges  5	      "localclr-namespace:FireWall  5
      a ]DevExpress.Xpf.Grid.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49af bDevExpress.Xpf.Grid.v15.1.Core, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   5      c	 _DevExpress.Xpf.Charts.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxc4http://schemas.devexpress.com/winfx/2008/xaml/charts 	 5      -   5        .��5      �� 
�������$��1q�6"   ._�5   
   � .+�5      ]� .+�5      � $	��Top=�6   .+�5      � $��30��6   $��	50,30,0,0q�6'   .+�5      �� $��发生时间��6    $��14(�6/   $
��Left=�6=   $��30��6X   $��0,0,0,0q�6d   $	��Top=�6u   $��59��6�   
�������$��0q�6�   $��Center=�6�   �� 5      $
��Left=�6'   $��1��6B   $��
260,14,0,0q�6M   $	��Top=�6a   $��20��6y   
���������6�   Z� 6�   %  DevExpress.Xpf.Editors.DateEdit  5      -   5           Name$  	StartDate��5   '   $
��Left=�6:   $��30��6U   $��82,0,0,0q�6a   $	��Top=�6s   $	��168��6�   %  DevExpress.Xpf.Editors.TextEdit   Mask$ F��6�      MaskType$
 None=�6�       AllowRoundOutOfRangeValue .    MaskUseAsDisplayFormat . %  DevExpress.Xpf.Editors.BaseEdit   StyleSettings 5      8  2DevExpress.Xpf.Editors.DateEditPickerStyleSettings  5   "   5        5      -   5        $  EndDate��5   '   $
��Left=�68   $��30��6S   $��	290,0,0,0q�6_   $	��Top=�6r   $	��168��6�   $ F��6�   $ Numeric=�6�    .  .  5        5   "   5       5!      � 5"      $��30��6   $��	50,20,0,0q�6'   .+�5#      �� $��防火墙MAC��6    $��14(�61   $
��Left=�6?   $��30��6Z   $��0,0,0,0q�6f   $	��Top=�6w   $��80��6�   
�������$��0q�6�   $��Center=�6�   )  #DevExpress.Xpf.Editors.ComboBoxEdit  5$      -   5          Name$ FwName��5$   +   *  $DevExpress.Xpf.Editors.PopupBaseEdit   ShowSizeGrip$ FalseY�6;   '  !DevExpress.Xpf.Editors.ButtonEdit   IsTextEditable$ FalseX�6P   $
��Left=�6�   $��30��6�   $	��Top=�6�   $	��150��6�   $��	100,0,0,0q�6�   	   ShowCustomItems	 6g   �� *	IsChecked+
 �� ElementName$
 CheckedShowCustomItems��6  5%      � 5&      $��30��6   $��	50,20,0,0q�6'   .+�5'      �� $��被保护设备IP��6    $��14(�62   $
��Left=�6@   $��30��6[   $��0,0,0,0q�6g   $	��Top=�6x   $��85��6�   
�������$��0q�6�   $��Center=�6�     5(      -   5        $ ProtectedIP��5(   +   $ FalseY�6@   $ FalseX�6U   $
��Left=�6�   $��30��6�   $	��Top=�6�   $	��130��6�   $��	105,0,0,0q�6  	 6l   �� *	IsChecked+$
 CheckedShowCustomItems��6  5)      � 5*      $��30��6   $��	50,20,0,0q�6'   .+�5+      �� $��处理状态��6    $��14(�6/   $
��Left=�6=   $��30��6X   $��0,0,0,0q�6d   $	��Top=�6u   $��60��6�   
�������$��0q�6�   $��Center=�6�     5,      -   5        $ 	StateName��5,   +   $ FalseY�6>   $ FalseX�6S   $��30��6�   $	��Top=�6�   $��80,0,0,0q�6�   $	��120��6�   	 6j   �� *	IsChecked+$
 CheckedShowCustomItems��6�   5-      � 5.      $��30��6   $��
200,20,0,0q�6'   .+�5/      �� -   5         ��Name$ Querybutton��5/   !   $��查询��66   $��14(�6C   $��0,0,0,0q�6Q   $	��Top=�6b   $��30��6z      MainButtonStyle#���   6�     buttongroundbrush#���  6�     	FontBrush#���  6�   $
��Left=�6$  $��75��6?  �� 50      -   5        $ Exportbutton��50   !   $��导出��67   $��14(�6D   $��	100,0,0,0q�6R   #���   6e   #���  6�   #���  6�   $��30��6  $
��Left=�6  $��75��6+  51      52      %  DevExpress.Xpf.Grid.GridControl  53      -	   5        $��LogData��53   "   )	  #DevExpress.Xpf.Grid.DataControlBase 	  AutoGenerateColumns$ AddNew=�61   # 	  EnableSmartColumnsGeneration .  	  
ShowBorder .     AllowLiveDataShaping$ FalseX�6�    	  SelectionMode$	 Row=�6�   $��50,50,50,50q�6�      View 54      #
  DevExpress.Xpf.Grid.TableView
  55      -
   5        $
��view��55   (    
  AllowPerPixelScrolling . &   DevExpress.Xpf.Grid.DataViewBase   ShowTotalSummary .    AllowEditing .   
  	AutoWidth .   
  EvenRowBackground �#C7EDCC 
  UseEvenRowBackground .    NavigationStyle$	 Row=�6�    
  PrintAutoWidth .  6�   57      58      59      5:      5;      