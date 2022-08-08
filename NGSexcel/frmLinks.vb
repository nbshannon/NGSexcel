Public Class frmLinks

    Private Sub frmLinks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'primers
        addlink("Primers", "Primer3", "http://frodo.wi.mit.edu/primer3/")
        addlink("Primers", "Batch Primer 3", "http://probes.pw.usda.gov/batchprimer3/index.html")
        addlink("Primers", "NCBI E-PCR", "http://www.ncbi.nlm.nih.gov/projects/e-pcr/")
        'UCSC
        addlink("UCSC", "Blat", "http://genome.ucsc.edu/cgi-bin/hgBlat?command=start")
        addlink("UCSC", "In-silico PCR", "http://genome.ucsc.edu/cgi-bin/hgPcr?command=start")
        addlink("UCSC", "Genome browser", "http://genome.ucsc.edu/cgi-bin/hgGateway?hgsid=224847919&clade=mammal&org=Human&db=hg19")
        'MutDB
        addlink("MutDB", "Cosmic", "http://www.sanger.ac.uk/resources/databases/cosmic.html")
        addlink("MutDB", "HGMD", "http://www.hgmd.org/")
        addlink("MutDB", "OMIM", "http://www.ncbi.nlm.nih.gov/omim")
        addlink("MutDB", "dbSNP", "http://www.ncbi.nlm.nih.gov/projects/SNP/")
        addlink("MutDB", "MutDB", "http://mutdb.org/")
        'EffPred
        addlink("EffPred", "Ensembl VEP", "http://www.ensembl.org/Homo_sapiens/UserData/UploadVariations")
        addlink("EffPred", "PolyPhen-2", "http://genetics.bwh.harvard.edu/pph2/")
        addlink("EffPred", "Sift", "http://sift.jcvi.org/")
        addlink("EffPred", "Mutation Taster", "http://www.mutationtaster.org/")
        addlink("EffPred", "Condel", "http://bg.upf.edu/group/projects/condel.php")
        'NGS tools
        addlink("NGS Tools", "Samtools", "http://samtools.sourceforge.net/")
        addlink("NGS Tools", "IGV", "http://www.broadinstitute.org/igv/")
    End Sub

    Private Sub addlink(ByVal tab As String, ByVal name As String, ByVal url As String)
        Dim mytab As System.Windows.Forms.TabPage
        If TabControl1.TabPages.ContainsKey(tab) Then
            mytab = TabControl1.TabPages(TabControl1.TabPages.IndexOfKey(tab))
        Else
            mytab = New System.Windows.Forms.TabPage
            mytab.Name = tab
            mytab.Text = tab
            mytab.BackColor = Drawing.Color.Transparent
            mytab.UseVisualStyleBackColor = True
            TabControl1.TabPages.Add(mytab)
            'check how many tabs we have and increase width of tabcontrl1 if necessary
        End If
        Dim link As System.Windows.Forms.LinkLabel = makeLinkLabel(name, url)
        mytab.Controls.Add(link)
        'need to check for moving to next column
        'maybe limit max number of controls before addin new tab with _2
        link.Location = New Drawing.Point(5, mytab.Controls.Count * 25 - 20)

    End Sub
    Private Function makeLinkLabel(ByVal name As String, ByVal url As String)
        Dim link As New System.Windows.Forms.LinkLabel
        link.Text = name
        link.Links.Add(0, name.Length, url)
        AddHandler link.LinkClicked, AddressOf newLink_Click
        makeLinkLabel = link
    End Function
    Private Sub newLink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        System.Diagnostics.Process.Start(sender.links(0).linkdata)
    End Sub
End Class