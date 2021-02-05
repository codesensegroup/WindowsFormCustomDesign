# WindowsFormCustomDesign
Simple custom material windows form element (All open sorce)

## Dialog

### Classification:
 - DialogOk : View with one Button 

![image](https://user-images.githubusercontent.com/20264622/107007688-d71eab00-67cd-11eb-9ac8-94a22f37c4b9.png)

 - DialogOKCancel : View with two Button (Check, Cancel)

![image](https://user-images.githubusercontent.com/20264622/107007779-f6b5d380-67cd-11eb-82d8-bd61d6e05802.png)

 - DialogOKCancel : View with three Button (Yes, No, Cancel)

![image](https://user-images.githubusercontent.com/20264622/107008017-3e3c5f80-67ce-11eb-9063-84583d319056.png)

### Simple Usage

```
    var dialog = new DialogOK("Title", "XXXAAA Content");

    //Self Definition
    dialog.SetBackGroundColor(Color.AliceBlue)
          .SetSelectImageIcon(2);
    dialog.SetButtonBackGroundColor(Color.Orange)
          .SetButtonText("Modify");

    dialog.ShowDialog();
```

## ProgressBar


![image](https://user-images.githubusercontent.com/20264622/107008369-ab4ff500-67ce-11eb-8892-f075bd35b683.png)

### Simple Usage

```
    customProgressBar.FillDegree = 100;
    customProgressBar.Refresh();
```


