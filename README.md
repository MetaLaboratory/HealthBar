// 3D compatible version of 2D tutorial here: https://www.youtube.com/watch?v=0tDPxNB2JNs
// this accesses the rect transform of the heathbar green "background Image"
// in a full 3d scene, you would need to import sprites to do the 2D youtube tutorial as is
// one issue with the 2d tut is it used the image as filled an dnot sliced, and this gave rounded corners unless edited
// this is the alternative, and is full 3d compatible
// the background image needs the X pivot set to 0 in inspector to scale from the left
// there are many ways to do this, this is one that uses just the UI background image, sliced images, and RectTransform to scale width (x in 2d vector))
// you could also access with: RectTransform healthBarRT = healthBar.GetComponent<RectTransform>();
