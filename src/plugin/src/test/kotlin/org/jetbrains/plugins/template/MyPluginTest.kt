package org.jetbrains.plugins.template

import com.intellij.ide.highlighter.XmlFileType
import com.intellij.psi.xml.XmlFile
import com.intellij.testFramework.TestDataPath
import com.intellij.testFramework.fixtures.BasePlatformTestCase
import com.intellij.util.PsiErrorElementUtil
import junit.framework.TestCase

@TestDataPath("\$CONTENT_ROOT/src/test/testData")
class MyPluginTest : BasePlatformTestCase() {

    fun testAllFake() {
        TestCase.assertTrue(true)
    }
}
