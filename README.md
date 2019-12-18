# animated-goggles
Interview question: Parse node values from XML document

## Question
2.	Taking the following XML document, write code to extract the RefText values for the following RefCodes:   ‘MWB’, ‘TRV’ and ‘CAR’
```
<InputDocument>
  <DeclarationList>
    <Declaration Command="DEFAULT" Version="5.13">
      <DeclarationHeader>
        <Jurisdiction>IE</Jurisdiction>
        <CWProcedure>IMPORT</CWProcedure>
        <DeclarationDestination>CUSTOMSWAREIE</DeclarationDestination>
        <DocumentRef>71Q0019681</DocumentRef>
        <SiteID>DUB</SiteID>
        <AccountCode>G0779837</AccountCode>
        <Reference RefCode="MWB">
          <RefText>586133622</RefText>
        </Reference>
        <Reference RefCode="KEY">
          <RefText>DUB16049</RefText>
        </Reference>
        <Reference RefCode="CAR">
          <RefText>71Q0019681</RefText>
        </Reference>
        <Reference RefCode="COM">
          <RefText>71Q0019681</RefText>
        </Reference>
        <Reference RefCode="SRC">
          <RefText>ECUS</RefText>
        </Reference>
        <Reference RefCode="TRV">
          <RefText>1</RefText>
        </Reference>
        <Reference RefCode="CAS">
          <RefText>586133622</RefText>
        </Reference>
        <Reference RefCode="HWB">
          <RefText>586133622</RefText>
        </Reference>
        <Reference RefCode="UCR">
          <RefText>586133622</RefText>
        </Reference>
        <Country CodeType="NUM" CountryType="Destination">IE</Country>
        <Country CodeType="NUM" CountryType="Dispatch">CN</Country>
 
          </DeclarationHeader>
</DeclarationList>
</InputDocument>
```
