<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="xml" encoding="UTF-8" indent="yes"/>
    <xsl:template match="/">
      <NewDataSet>      
        <xsl:for-each select="Processes/Process">
        <xsl:choose>
        <xsl:when test ="count(./Steps/Step[@Type='Execute']) > 0">
            <xsl:for-each select="./Steps/Step[@Type='Execute']">
              <SQL>    
                <Category>
                   <xsl:value-of select="../../@Category"/>
                </Category>
                <ProcessName>
                      <xsl:value-of select="../../@Name"/>
                </ProcessName>
                <ExecuteProcessName>
                     <xsl:value-of select="Properties/Property/Value"/>
                </ExecuteProcessName>
            </SQL>
            </xsl:for-each> 
        </xsl:when>
        <xsl:otherwise>
             <SQL>    
                <Category>
                   <xsl:value-of select="@Category"/>
                </Category>
                <ProcessName>
                      <xsl:value-of select="@Name"/>
                </ProcessName>
                <ExecuteProcessName>
                </ExecuteProcessName>
            </SQL>
        </xsl:otherwise>    
        </xsl:choose>                       
        </xsl:for-each>
      </NewDataSet>
    </xsl:template>
</xsl:stylesheet> 