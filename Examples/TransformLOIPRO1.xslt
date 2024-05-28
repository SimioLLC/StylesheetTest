<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" >
    <xsl:output method="xml" encoding="UTF-8" indent="yes"/>
     <xsl:template name="formatdate">
		 <xsl:param name="DateTimeStr" /> 
		 <xsl:variable name="mm">
			 <xsl:value-of select="substring($DateTimeStr,5,2)" />
		 </xsl:variable>
		 <xsl:variable name="dd">
			<xsl:value-of select="substring($DateTimeStr,7,2)" />
		 </xsl:variable>
		 <xsl:variable name="yyyy">
			<xsl:value-of select="substring($DateTimeStr,1,4)" />
		 </xsl:variable> 
     <xsl:value-of select="concat($yyyy,'-', $mm, '-', $dd)" />
  </xsl:template>
	<xsl:template match="/">
      <NewDataSet>      
        <xsl:for-each select="LOIPRO01/IDOC/E1AFKOL">
          <SQL>
            <OrderID>
              <xsl:value-of select="AUFNR"/>
            </OrderID>
            <MaterialName>
              <xsl:value-of select="MATNR"/>
            </MaterialName>
            <Quantity>
                <xsl:value-of select="BMENGE"/>
            </Quantity>  
            <ReleaseDate>
                <xsl:call-template name="formatdate">
                    <xsl:with-param name="DateTimeStr" select="GLTRP"/>
                </xsl:call-template>
            </ReleaseDate> 
            <DueDate>
                <xsl:call-template name="formatdate">
                    <xsl:with-param name="DateTimeStr" select="GLTRS"/>
                </xsl:call-template>
            </DueDate> 			
          </SQL>               
        </xsl:for-each>
      </NewDataSet>
    </xsl:template>
</xsl:stylesheet>