<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

    <xsl:output method="xml" indent="yes"/>

    <xsl:template match="/Pay">
        <Employees>
            <xsl:choose>
                <xsl:when test="item">
                    <xsl:apply-templates select="item"/>
                </xsl:when>
                <xsl:when test="*[1][self::january or self::february or self::march or self::april or self::may or self::june or self::july or self::august or self::september or self::october or self::november or self::december]">
                    <xsl:apply-templates select="*/*"/>
                </xsl:when>
            </xsl:choose>
        </Employees>
    </xsl:template>

    <xsl:key name="emps" match="*/*" use="concat(@name, '|', @surname)"/>

    <xsl:template match="item | */*">
        <xsl:if test="generate-id() = generate-id(key('emps', concat(@name, '|', @surname))[1])">
            <Employee>
                <xsl:attribute name="name">
                    <xsl:value-of select="@name"/>
                </xsl:attribute>
                <xsl:attribute name="surname">
                    <xsl:value-of select="@surname"/>
                </xsl:attribute>
                <xsl:for-each select="key('emps', concat(@name, '|', @surname))">
                    <salary>
                        <xsl:attribute name="amount">
                            <xsl:value-of select="@amount"/>
                        </xsl:attribute>
                        <xsl:attribute name="mount">
                            <xsl:value-of select="@mount"/>
                        </xsl:attribute>
                    </salary>
                </xsl:for-each>
            </Employee>
        </xsl:if>
    </xsl:template>

</xsl:stylesheet>