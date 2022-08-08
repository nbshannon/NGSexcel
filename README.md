# NGSexcel
An add-in for Microsoft excel for working with genomic variants

## Introduction

Several next generation sequencing (NGS) companies supply the raw data along with downstream analysis including alignment, variant calling and annotation of these variants. When this downstream data is not available there are already a number of methods publically available and in development for calling variants (mpileup, pindel, somaticSNiPer, breakdancer, CREST, genome STRiP), and annotation (SnpEff, Annovar, ASOoViR, SNPnexus, Ensembl VEP).
Commonly this information is generated as a flatfile and imported into Microsoft Excel for manual filtering. For non bioinformaticians this may be the only way they will view the data (alongside visualisation tools such as Circos and genome browsers). In addition non-bioinformaticians are less likely to have immediate access to script interpreters and compilers for writing custom algorithms or utilising open source code.
However the large number of variants called with NGS, particularly for whole genome sequencing may exceed the maximum number of lines in Excel (65536 for 2003, 1048576 since Excel 2007), resulting in incomplete loading of files opened in Excel. Currently variants identified by NGS must be validated, which may require pulling flanking reference genomic sequence information to use in PCR primer design.

## NGSxl

To address these needs I have developed NGSxl a Microsoft Excel (2007) plugin written in visual basic aimed at users working with genomic variation data. The plugin provides the ability to split very large text files that exceed the maximum lines in Excel into shorter (reduced number of lines) files which can be read without losing information. At the same time the user can add additional criteria to split files and/or filter which lines are included based on column values, such as variant type or quality metrics.
For working with genomic data in Excel the plugin allows the user to hyperlink genomic coordinates to genome browsers (Ensembl, UCSC), and to pull reference sequence information from a DAS server (Ensembl, UCSC) in a format suitable for loading into primer design software (e.g. Primer3). Both of these functions can be implemented for hg18 or hg19 assemblies.

## Functions

* Split up large files (exceeding Excel max lines limit into multiple smaller files)
* Link to ensembl or UCSC genome browser by chr/start/end columns (will auto select if given header row)
* Get sequence for a given location, or get a batch of sequences from a column of genomic coordinates, with option to extend either side of target region (useful for designing primers)
* Combine to genomic coordinates: add a column containing combined genomic coordinates from chr/start/end columns
