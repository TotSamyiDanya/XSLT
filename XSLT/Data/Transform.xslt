<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:output method="xml" indent="yes"/>

	<!-- Корень -->
	<xsl:template match="/Pay">
		<Employees>
			<!-- Обработка Data1 -->
			<xsl:choose>
				<xsl:when test="item">
					<xsl:apply-templates select="item"/>
				</xsl:when>
				<!-- Обработка Data2 -->
				<xsl:when test="*[1][self::january or self::february or self::march or self::april or self::may or self::june or self::july or self::august or self::september or self::october or self::november or self::december]">
					<xsl:apply-templates select="*/*"/>
				</xsl:when>
			</xsl:choose>
		</Employees>
	</xsl:template>

	<!-- Обработка Data1 -->
	<xsl:template match="item">
		<xsl:variable name="name" select="@name"/>
		<xsl:variable name="surname" select="@surname"/>
		<xsl:variable name="amount" select="@amount"/>
		<xsl:variable name="mount" select="@mount"/>

		<Employee>
			<xsl:attribute name="name">
				<xsl:value-of select="$name"/>
			</xsl:attribute>
			<xsl:attribute name="surname">
				<xsl:value-of select="$surname"/>
			</xsl:attribute>
			<salary>
				<xsl:attribute name="amount">
					<xsl:value-of select="$amount"/>
				</xsl:attribute>
				<xsl:attribute name="mount">
					<xsl:value-of select="$mount"/>
				</xsl:attribute>
			</salary>
		</Employee>
	</xsl:template>

	<!-- Обработка Data2 -->
	<xsl:template match="*/*">
		<Employee>
			<xsl:attribute name="name">
				<xsl:value-of select="@name"/>
			</xsl:attribute>
			<xsl:attribute name="surname">
				<xsl:value-of select="@surname"/>
			</xsl:attribute>
			<salary>
				<xsl:attribute name="amount">
					<xsl:value-of select="@amount"/>
				</xsl:attribute>
				<xsl:attribute name="mount">
					<xsl:value-of select="@mount"/>
				</xsl:attribute>
			</salary>
		</Employee>
	</xsl:template>

</xsl:stylesheet>