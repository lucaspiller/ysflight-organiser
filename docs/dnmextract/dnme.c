/* DNM Extract - Split a .dnm into the .srfs contained inside it
   Copyright (C) 2005 Luca Spiller

   DNM Extract is free software; you can redistribute it and/or
   modify it under the terms of the GNU General Public
   License as published by the Free Software Foundation; either
   version 2 of the License, or (at your option) any later version.

   DNM Extract is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
   General Public License for more details.

   You should have received a copy of the GNU General Public
   License along with the DNM Extract; if not, write to the Free
   Software Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA
   02111-1307 USA.  */

#include <stdio.h>
#define false 0
#define true 1

const char version[] = "0.1";

// get a line from file that isn't a line < 5 characters long (handling of 'blank' lines)
char *getli(FILE *file)
{
	char *str = (char*) malloc(1024);

	while (strlen(str) < 5)
		fgets(str, 1024, file);
		
	return str;
}

int main(int argc, char *argv[])
{
	FILE *input_dnm, *output_srf = NULL;
	
	// heh, you never know, we might have a stf with 4294967295 lines
	unsigned long linecount = 0;
	
	char *str = (char*) malloc(1024);
	char *filename = (char*) malloc(1024);
	
	int writing = false;

	// some nice helpful information for the user
	if (argc == 1) {
		printf("dnme: Missing input file\n");
		printf("Usage: dnme FILE\n\n");
		printf("Try `dnme --help`.\n");
		return 0;
	}
	
	// and a bit more
	if (strcmp(argv[1], "--help") == 0 || strcmp(argv[1], "-h") == 0)
	{
		printf("DNM Extract version %s\n", version);
		printf("Usage: dnme FILE\n\n");
		printf("Split a .dnm into the .srfs contained inside it.\n\n");
		printf("Mail bug reports and suggestions to <thelucster@gmail.com>.\n");
		return 0;
	}	
	
	// now the program begins
	input_dnm = fopen(argv[1], "r");
	
	if (!input_dnm) // test to see if we can open it
	{
		printf("There was an error opening `%s`.\nDoes it actually exist?\n", argv[1]);
		return -1;
	}
	
	printf("Extracting `%s`...\n\n", argv[1]);
	
	// we don't need the first two lines
	str = getli(input_dnm);
	str = getli(input_dnm);
	
	// now for the complicated bit
	// we look through the dnm looking for the bits stating srfs
	// and when we find one we read it to find out the filename, and how many lines there are in it
	// next we open the file, and then start writing until the end of it, and so on
	while (!feof(input_dnm))
	{
		if (linecount < 1)
		{
			if (output_srf != NULL) // if we already have an open file it is a good idea to close it first
				fclose(output_srf);
				
			str = getli(input_dnm); // now read the line for the srf

			sscanf(str, "PCK %s %d", filename, &linecount); // and get the filename and number of lines
			if (linecount == 0 && strstr(str, "SRF \"") != NULL) {
				printf("\nFound `SRF \"*\"`. Finishing up...\n");
				break;
			}
			
			printf("Writing %u lines to `%s`\n", linecount, filename);
			
			output_srf = fopen(filename, "w"); // open it for writing
			if (!output_srf) {// and make sure it did open
				writing = false;
				printf("Something went wrong opening `%s`.\n", filename);
			} else
				writing = true;
		}
		
		fgets(str, 1024, input_dnm);
		linecount--;
		
		if (writing) // incase anything went wrong, we don't want to write to something that doesn't exist
			fputs(str, output_srf);
	}
	
	if (feof(input_dnm))
		printf("\nEnd of file. Finishing up...\n");
	
	fclose(output_srf);
	fclose(input_dnm);
	
	return 0;
}
