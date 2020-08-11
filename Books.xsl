<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:template match="/">
		<html>
			<body>
				<h1 style="background-color: green; color: white; font-size: 24pt; text-align: center">
					Barnes &amp; Noble Top 20: Book Bestsellers
				</h1>
				<xsl:for-each select="Books/Book">
					<div style="border: 2px #000000 solid">
						<ul>
							<li>
								<label>ISBN: </label>
								<label><xsl:value-of select="Isbn"/></label>
							</li>
							<li>
								<label>Title: </label>
								<label><xsl:value-of select="Title"/></label>
							</li>
							<li>
								<label>Cover: </label>
								<label><xsl:value-of select="@Cover"/></label>
							</li>
							<li>
								<xsl:for-each select="Author">
									<label>Author: </label>
									<label><xsl:value-of select="Name/First"/>&#160;</label>
									<label><xsl:value-of select="Name/Last"/>&#160;</label><br />
									<label>Office: </label>
									<label><xsl:value-of select="Contact/@Office"/></label><br />
									<label>Phone: </label>
									<label><xsl:value-of select="Contact/Phone"/></label><br />
								</xsl:for-each>
							</li>
							<li>
								<label>Publisher: </label>
								<label><xsl:value-of select="Publisher"/></label>
							</li>
							<li>
								<label>Year: </label>
								<label><xsl:value-of select="Year"/></label>
							</li>
							<li>
								<label>Edition: </label>
								<label><xsl:value-of select="Year/@Edition"/></label>
							</li>
							<li>
								<label>Frequently Bought Together: </label>
								<xsl:for-each select="FBT">
									<label><xsl:value-of select="Isbn"/></label><br />
								</xsl:for-each>
							</li>
						</ul>
					</div>
				</xsl:for-each>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
