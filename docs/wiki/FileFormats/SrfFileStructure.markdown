# SRF File Structure

SURF files (SRF for short) are simple polgyon models. The first part is the header, as shown below:

    SURF

## Vertices

A vertex can be defined by specifying V, followed by the x, y and z coordinates.

    V 0 0 0

That will draw a vertex at (0, 0, 0). Optionally an R can be added to the end which will tell the renderer to draw the surface smoothly over this vertex.

    V 5.5 4.3 -9.6 R
    
That will draw a smooth vertex at (5.5, 4.3, -9.6).

Each vertex has an ID in the order it is listed in the SRF file. The first will have ID 0, the second ID 1, etc...

## Polygons

After the vertices have been defined, polygons need to be. A completed polygon is shown below:

    F 
    C 16912
    N -0.004 0.686 1.960 0.000 0.000 0.000
    V 28 27 19 1 8
    E

The F is the polygon header, on the next line is the colour value, as a 15 bit colour. See below to convert colours to this format.

Colours can also be specified in R G B format, but these are not supported by some YSFlight tools:

    C 144 45 235

Next is the gravity centre (the first triplet) and the normal (the second triplet). The normal must go towards the outside of the object. If the normal is zero, a two sided polygon is created.

The next line specifies the IDs of vertices to use for this polygon, and finally the E specifies the end of a polygon section.

### Colour converter

The following script will convert 8-bit colour components into a 15-bit colour. Enter a number between 0 and 255 in the R, G and B boxes and click Convert.

<script type="text/javascript">
	function convert()
	{
		var r = parseInt(document.getElementById('r').value);
		var g = parseInt(document.getElementById('g').value);
		var b = parseInt(document.getElementById('b').value);
		
		if (r == NaN || g == NaN || b == NaN)
		{
			alert('Please enter valid numbers!');
			return;
		}
		
		if (r < 0 || r > 255 || g < 0 || g > 255 || b < 0 || b > 255)
		{
			alert('Please enter a value between 0 and 255!');
			return;
		}
		
		document.getElementById('15bit').value = Math.round(((g / 8 ) * 1024) + ((r / 8) * 32) + (b / 8), 0).toString();
	}
</script>

<form onsubmit="convert(); return false;">
	<p>
		R: <input type="text" id="r" onclick="this.value = '';" />
		G: <input type="text" id="g" onclick="this.value = '';" />
		B: <input type="text" id="b" onclick="this.value = '';" />
	</p>
	<p>
		15-bit Colour: <input type="text" id="15bit" />
	</p>
	<p>
		<input type="submit" value="Convert" />
	</p>
</form>

## Transparency

The OpenGL version of YSFlight enables transparency, to make a vertex transparent use the ZA command:

    ZA 0 128
    
The first value if the vertex ID, and the second the level of transparency between 0 and 255, where 0 is opaque. These can be repeated on the same line as many times as required.

    ZA 1 128 5 128 7 128
    
To achieve a similar result in non-OpenGL versions of the game you can hide vertices using the ZZ command:

    ZZ 1 5 7
    
Each value is the ID of a vertex to hide.

## Footer

To finish off the SRF put an E on a line by itself, this does not appear to be required:

    E

## Sample SRF

Here is a sample SRF file, which will produce a cube:

    SURF
    V -6.0 -6.0 -6.0 R
    V 6.0 -6.0 -6.0 R
    V -6.0 6.0 -6.0 R
    V 6.0 6.0 -6.0 R
    V -6.0 -6.0 6.0 R
    V 6.0 -6.0 6.0 R
    V -6.0 6.0 6.0 R
    V 6.0 6.0 6.0 R
    F
    C 31
    N 0.0 0.0 -6.0 0.0 0.0 -1.0
    V 0 1 3 2
    E
    F
    C 31
    N 0.0 0.0 6.0 0.0 0.0 1.0
    V 6 7 5 4
    E
    F
    C 31
    N 0.0 -6.0 0.0 0.0 -1.0 0.0
    V 4 5 1 0
    E
    F
    C 31
    N 6.0 0.0 0.0 1.0 0.0 0.0
    V 5 7 3 1
    E
    F
    C 31
    N 0.0 6.0 0.0 0.0 1.0 0.0
    V 7 6 2 3
    E
    F
    C 31
    N -6.0 0.0 0.0 -1.0 0.0 0.0
    V 6 4 0 2
    E
    E

## Reference

This document is based heavily on the information available at:

[http://cielab3.me.cmu.edu/~soji/ysclass/reference.html#SRF-FORMAT](http://cielab3.me.cmu.edu/~soji/ysclass/reference.html#SRF-FORMAT)