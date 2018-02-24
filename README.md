# UWP ListView Overflow Bug sample

This repository demonstrates a ListView overflow bug in UWP. It has been noticed by developers on [Stack Overflow](https://stackoverflow.com/questions/48882616/uwp-list-view-overflow-with-large-list/48883664#48883664) and on [Visual Studio feedback](https://developercommunity.visualstudio.com/content/problem/52049/uwp-listview-viewport-overflow.html) but it seems it hasn't been officially reported yet.

## Bug description

When a very large number of items is bound to a `ListView`-based control (including `GridView` and controls built upon this like Telerik `DataGrid`), the control overflows its calculated bottom boundary. This makes it impossible to use the control in a container as the oveflow covers the controls underneath. Only way to resolve this is to make the list stretch the height of the app view.

## Steps to reproduce
 
- Create a `Grid` with two rows of equal height (`*`)
- Create a `ListView` control and put it in the first row of the `Grid`
- Define a `ObservableCollection<int>` property in the page's code-behind with more than 50 000 items:

- Bind `ListView`'s `ItemsSource` to the property
- Launch the app

### Expected behavior

List should stay within the first row of the `Grid`

### Actual behavior

List overflows into the second row of the `Grid`. Reveal effects appear in the second `Grid`, but focus or selection of `ListView` items do not work which indicates the control *is* in fact only within the first row.

![Sample](https://raw.githubusercontent.com/MartinZikmund/UWPListViewOverflowBug/master/UWPListViewOverflowBug/OverflowImage.JPG)

