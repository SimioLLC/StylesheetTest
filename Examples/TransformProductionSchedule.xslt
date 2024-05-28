<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:bml="http://www.wbf.org/xml/b2mml-v0400">
    <xsl:output method="xml" encoding="UTF-8" indent="yes"/>
    <xsl:template match="/">
      <NewDataSet>      
        <xsl:for-each select="bml:SyncProductionSchedule/bml:DataArea/bml:ProductionSchedule/bml:ProductionRequest/bml:SegmentRequirement">
          <SQL>
              <OrderId>
                <xsl:value-of select="bml:ID"/>
              </OrderId>
              <MaterialName>
                <xsl:value-of select="bml:MaterialRequirement/bml:MaterialDefinitionID"/>
              </MaterialName>
              <Quantity>
                <xsl:value-of select="bml:MaterialRequirement/bml:Quantity/bml:QuantityString"/>
              </Quantity>
              <ReleaseDate>
                <xsl:value-of select="bml:EarliestStartTime"/>
              </ReleaseDate>
              <DueDate>
                <xsl:value-of select="bml:LatestEndTime"/>
              </DueDate>
            </SQL>               
        </xsl:for-each>
      </NewDataSet>
    </xsl:template>
</xsl:stylesheet> 