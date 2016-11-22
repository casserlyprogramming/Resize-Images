# Resize-Images
resize images on your windows computer using a handy right click

Resize Images is a c# app for creating the necessary registry input for a right click menu item in windows. The right click will resize the images to the size that is also stored in the registry. 

The installer is included and written in nsis.

The projects are as follows:

ResizeImages2 - The program that performs the resize. It takes registry values and arguments of file names. Will show a message if it fails (ie you try to resize an executable)

ResizeImagesRegKeys - The program that deals with creating/editing RegKeys

ResizeImagesSettings - A Winforms app for changing the settings such as the height and width and also has a button to create the reg keys. 

Suggestions and forking is welcome and encouraged. Please commit changes to me @ daniel@casserlyprogramming.com and I will include them if they are worthy :-)
